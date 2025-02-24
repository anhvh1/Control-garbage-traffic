import React, { useEffect, useState, useRef } from "react";
import { TransformWrapper, TransformComponent } from "react-zoom-pan-pinch";
import TrashMap from "../../image/maprac.jpg";
import { motion } from "framer-motion";
import { TruckWrapper, TrashWrapper } from "./index.styled";
import PaperImg from "../../image/paper.png";
import TrashCan from "../../image/recycling-bin.png";
import * as signalR from "@microsoft/signalr";
import MapWrapper from "./index.styled";
import api from "./config";
import "./style.css";

// import { motion } from "framer-motion";
const ZoomableImage = () => {
  const [data, setData] = useState([]);
  console.log("data", data);
  const [connectionStatus, setConnectionStatus] = useState("Disconnected");
  const reconnectInterval = 10000; // Thời gian thử reconnect: 10 giây
  const connectionRef = useRef(null);
  const reconnectTimerRef = useRef(null);
  const [isTrashDumping, setIsTrashDumping] = useState(false);
  const [truckPositions, setTruckPositions] = useState([]);

  useEffect(() => {
    const startConnection = async () => {
      if (connectionRef.current) {
        console.log("Connection already exists, skipping start...");
        return;
      }

      connectionRef.current = new signalR.HubConnectionBuilder()
        // .withUrl("https://nx-emotional.gosol.com.vn/emotion", { withCredentials: false })
        .withUrl("https://nx.gosol.com.vn/mapHub", { withCredentials: false })
        .build();

      connectionRef.current.on("ReceiveConnectionInfo", async (response) => {
        setData(response.data);
      });

      connectionRef.current.on("ReceiveTrashUpdate", async (response) => {
        const newData = [...response.data];
        try {
          newData.forEach((item, index) => {
            if (item?.loaiThayDoi === 1) {
              newData[index].XaRac = true;
            } else if (item?.loaiThayDoi === 2) {
              newData[index].ThuGomRac = true;
            }
          });
          // console.log(newData, "newData");
          setData(newData);
          // handleTrashDumping(newData);
          setTimeout(() => {
            const newData = [...response.data].map((item) => ({
              ...item,
              XaRac: false,
              ThuGomRac: false,
            }));
            setData(newData);
          }, 1500);
        } catch (err) {
          console.log(err, "err ");
        }
      });

      connectionRef.current.onclose(() => {
        setConnectionStatus("Disconnected");
        scheduleReconnect();
        setData({});
      });

      try {
        await connectionRef.current.start();
        setConnectionStatus("Connected");
        console.log(`SignalR connected for `);
        await connectionRef.current.invoke("Connection");
      } catch (err) {
        console.error("Connection error:", err);
        scheduleReconnect();
      }
    };

    const scheduleReconnect = () => {
      if (reconnectTimerRef.current) clearTimeout(reconnectTimerRef.current);
      reconnectTimerRef.current = setTimeout(() => {
        console.log(`Attempting to reconnect for device ...`);
        startConnection();
      }, reconnectInterval);
    };

    startConnection();

    return () => {
      if (reconnectTimerRef.current) clearTimeout(reconnectTimerRef.current);
      if (connectionRef.current) {
        connectionRef.current
          .stop()
          .then(() => console.log(`SignalR connection stopped for device `));
        connectionRef.current = null;
      }
    };
  }, []);

  const renderPosition = (index) => {
    switch (index) {
      case 0:
        return { top: "60%", left: "34%" };
      case 1:
        return { top: "44%", left: "11%" };
      case 2:
        return { top: "37%", left: "26%" };
      case 3:
        return { top: "29%", left: "34%" };
      case 4:
        return { top: "21.5%", left: "54.5%" };
      case 5:
        return { top: "37%", left: "62%" };
      case 6:
        return { top: "27%", left: "74.5%" };
      case 7:
        return { top: "31.5%", left: "92%" };
      case 8:
        return { top: "51%", left: "78%" };
      case 9:
        return { top: "74%", left: "51%" };
      default:
        return { top: `${30 * index}%`, left: `${20 * index}%` };
    }
  };

  // Hàm xử lý sự kiện khi nhấn nút đổ rác
  const handleTrashDumping = (item, index) => {
    // console.log(item, "item");
    // console.log(data, "data");

    setIsTrashDumping(true);
    // Giả sử bạn muốn xe rác đi tới các thùng rác đầy
    const positions = renderPosition(index);
    // .map((item, index) => {
    //   if (item.trangThaiDay === 2) {
    //     return renderPosition(index);
    //   }
    //   return null;
    // })
    // .filter((position) => position !== null);
    // console.log(positions, "positions");
    // console.log(data, "data");
    // setTruckPositions([positions]);
    // Sau 2 giây xe rác sẽ di chuyển và biến mất
    // setTimeout(() => {
    //   setIsTrashDumping(false);
    //   setTruckPositions([]);
    api
      .ClearTrash({
        Code: item.maCamera,
        Type: 2,
      })
      .then((res) => {
        if (res.status === 200) {
        }
      });
    // }, 6000); // Tổng thời gian animation (6s)
  };

  // console.log(truckPositions, "trucksPosition");

  const Truck = ({ style }) => {
    const { top, left } = style;
    const newLeft = left ? `calc(${left} + 70px)` : null;
    const maxLeft = newLeft ? `calc(${left} + 140px)` : null;

    return (
      <TruckWrapper left={newLeft} maxLeft={maxLeft}>
        <div class="loader-wrapper">
          <div
            class="truck-wrapper"
            style={{ top: `calc(${top} - 20px)`, left }}
          >
            <div class="truck">
              <div class="truck-container">
                <div class="logo">
                  <img src="https://logos-world.net/wp-content/uploads/2021/10/Recycle-Symbol.png" />
                </div>
              </div>
              <div class="glases"></div>
              <div class="line-glases"></div>
              <div class="bonet"></div>
              <div class="base"></div>
              <div class="line"></div>
              <div class="line"></div>
              <div class="base-aux"></div>
              <div class="wheel-back"></div>
              <div class="wheel-front"></div>

              <div class="smoke"></div>
            </div>
          </div>
        </div>
      </TruckWrapper>
    );
  };

  return (
    <MapWrapper
      className="zoom-container"
      style={{ overflow: "hidden", width: "100%", height: "100%" }}
    >
      <TransformWrapper
        initialScale={1}
        alignmentAnimation={{ sizeX: 0, sizeY: 0 }}
        initialPositionX={0}
        initialPositionY={0}
        minScale={1} // Không cho phép zoom out
        maxScale={5} // Giới hạn zoom in
        wheel={{ step: 0.1 }}
        limitToBounds={true} // Giới hạn di chuyển trong vùng ảnh
        panning={{ disabled: false }} // Cho phép pan (di chuyển)
        doubleClick={{ disabled: true }} // Tắt zoom bằng double-click
        pinch={{ disabled: false }} // Cho phép zoom bằng pinch gesture (trên mobile)
        centerZoomedOut={true}
      >
        {({ zoomIn, zoomOut, resetTransform }) => (
          <>
            {/* <button onClick={handleTrashDumping}>Đổ Rác</button> */}
            {data &&
              data.length &&
              truckPositions.map((position, index) => (
                <Truck
                  key={index}
                  // className="truck"
                  style={{
                    top: position.top,
                    left: position.left,
                  }}
                />
              ))}
            {/* <Truck /> */}
            <TransformComponent>
              <img
                src={TrashMap}
                alt="Zoomable"
                className="img-map"
                style={{ width: "100vw", display: "block" }}
              />
              {data && data.length
                ? data.map((item, index) => {
                    const position = renderPosition(index);
                    const { trangThaiDay } = item;
                    const currentAmount = item.soLuongRacHienTai;
                    const maxCapacity =
                      item.sucChuaToiDa - item.soLuongRacHienTai;

                    console.log("maxCapacity", maxCapacity);
                    let barColor = "#4CAF50";
                    let widthPercentage = 0;

                    if (currentAmount === maxCapacity) {
                      barColor = "#F44336";
                      widthPercentage = 100;
                    } else if (currentAmount > 0) {
                      widthPercentage =
                        (currentAmount / item.sucChuaToiDa) * 100;
                      barColor = `linear-gradient(to right, #F44336 ${widthPercentage}%, #4CAF50 ${widthPercentage}%)`; // Hiển thị màu đỏ và xanh lá cây
                    }

                    return (
                      <>
                        <TrashWrapper top={position.top} left={position.left}>
                          <div
                            className="trash-wrap"
                            onClick={() => {
                              handleTrashDumping(item);
                            }}
                          >
                            <div
                              style={{
                                width: "80%",
                                margin: "0 10%",
                                height: "5px",
                                background: barColor,
                                borderRadius: "5px",
                                marginBottom: "10px",
                                boxShadow: "0 2px 5px rgba(0, 0, 0, 0.2)", // Added shadow for depth
                                transition:
                                  "background 0.3s ease, transform 0.3s ease, box-shadow 0.3s ease", // Smooth transition for background color and transform
                                cursor: "pointer", // Change cursor to pointer
                              }}
                              onMouseEnter={(e) => {
                                e.currentTarget.style.transform = "scale(1.05)"; // Scale up on hover
                                e.currentTarget.style.boxShadow =
                                  "0 4px 10px rgba(0, 0, 0, 0.3)"; // Increase shadow on hover
                              }}
                              onMouseLeave={(e) => {
                                e.currentTarget.style.transform = "scale(1)"; // Scale back to original size
                                e.currentTarget.style.boxShadow =
                                  "0 2px 5px rgba(0, 0, 0, 0.2)"; // Reset shadow
                              }}
                            />
                            <img
                              src={TrashCan}
                              alt="Trash Can"
                              className={
                                item.soLuongRacHienTai >= item.sucChuaToiDa
                                  ? "shake"
                                  : ""
                              }
                            />
                          </div>
                        </TrashWrapper>
                      </>
                    );
                  })
                : null}
            </TransformComponent>
          </>
        )}
      </TransformWrapper>
    </MapWrapper>
  );
};

export default ZoomableImage;
{
  /* <span
                              class={`trash ${
                                trangThaiDay ? "trash-full" : null
                              } ${item.XaRac ? "throw-trash" : null} `}
                              onClick={() => {
                                console.log("clicked item");
                                handleTrashDumping(item);
                              }}
                            >
                              <span></span>
                              <i></i>
                            </span> */
}
{
  /* {item.XaRac ? (
                              <div className="paper-img">
                                <img
                                  className="img"
                                  src={PaperImg}
                                  alt="trash paper"
                                />
                                <img
                                  className="img"
                                  src={PaperImg}
                                  alt="trash paper"
                                />
                                <img
                                  className="img"
                                  src={PaperImg}
                                  alt="trash paper"
                                />
                              </div>
                            ) : null} */
}
