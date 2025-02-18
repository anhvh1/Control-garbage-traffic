import React, { useEffect, useState, useRef } from "react";
import { TransformWrapper, TransformComponent } from "react-zoom-pan-pinch";
import TrashMap from "../../image/TrashMap.jpg";
import { motion } from "framer-motion";
import { TruckWrapper, TrashWrapper } from "./index.styled";
import PaperImg from "../../image/paper.png";
import * as signalR from "@microsoft/signalr";
import MapWrapper from "./index.styled";
// import { motion } from "framer-motion";
const ZoomableImage = () => {
  const [data, setData] = useState([]);
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
            if (item?.loaiThayDoi) {
              newData[index].XaRac = true;
            }
          });
          console.log(newData, "newData");
          setData(newData);
          setTimeout(() => {
            const newData = [...response.data].map((item) => ({
              ...item,
              XaRac: false,
            }));
            console.log(newData, "resign data");
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
        return { top: "45%", left: "5%" };
      case 1:
        return { top: "65%", left: "70%" };
      default:
        return { top: `${30 * index}%`, left: `${20 * index}%` };
    }
  };

  // Hàm xử lý sự kiện khi nhấn nút đổ rác
  const handleTrashDumping = () => {
    setIsTrashDumping(true);

    // Giả sử bạn muốn xe rác đi tới các thùng rác đầy
    const positions = data
      .map((item, index) => {
        if (item.trangThaiDay) {
          return renderPosition(index);
        }
        return null;
      })
      .filter((position) => position !== null);

    setTruckPositions(positions);

    // Sau 2 giây xe rác sẽ di chuyển và biến mất
    // setTimeout(() => {
    //   setIsTrashDumping(false);
    //   setTruckPositions([]);
    // }, 6000); // Tổng thời gian animation (6s)
  };

  console.log(truckPositions, "trucksPosition");

  const Truck = ({ style }) => {
    const { top, left } = style;
    const newLeft = left ? `calc(${left} + 70px)` : null;
    const maxLeft = newLeft ? `calc(${left} + 140px)` : null;
    console.log(maxLeft, "maxLeft");
    return (
      <TruckWrapper left={newLeft} maxLeft={maxLeft}>
        <div class="loader-wrapper">
          <div class="truck-wrapper" style={{ top, left }}>
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
            <button onClick={handleTrashDumping}>Đổ Rác</button>
            {isTrashDumping &&
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
                    return (
                      <>
                        <TrashWrapper top={position.top} left={position.left}>
                          <div className="trash-wrap">
                            <span
                              class={`trash ${
                                trangThaiDay ? "trash-full" : null
                              } ${item.XaRac ? "throw-trash" : null} `}
                            >
                              <span></span>
                              <i></i>
                            </span>
                            {/* {isOpenTrash ? ( */}
                            {item.XaRac ? (
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
                            ) : null}
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
