import styled, { keyframes } from "styled-components";

const createKeyframes = (left, maxLeft) => keyframes`
  0% {
    left: -200px;  /* Xe bắt đầu từ ngoài màn hình bên trái */
    opacity: 1;
  }
  40% {
    left: ${left};  /* Di chuyển đến vị trí thùng rác */
    opacity: 1;
  }
  60% {
    left: ${left};  /* Dừng lại tại thùng rác */
    opacity: 1;
  }
  100% {
    left: ${maxLeft};  /* Dừng lại tại thùng rác */
    opacity: 0;
    display: none;
  }
`;

const MapWrapper = styled.div`
  height: "100vh";
  .fullmap {
    /* height: 100vh; */
  }
  /* @media only screen and (max-height: 800px) {
    .img-map {
      height: auto !important;
    }
  } */
  .img-map {
    height: 100vh;
  }
`;

const backgroundFullTrash = "#ff6873";
const backgroundNomarl = "#8ecbfd";
const basepx = "16px";

const em = (target, context) => {
  if (target == 0) return 0;
  return target / context + "em";
};

const TrashWrapper = styled.div`
  position: absolute;
  top: ${(props) => `${props.top}`};
  left: ${(props) => `${props.left}`};
  .trash-wrap {
    position: relative;
    display: inline-block;
    width: 40px;

    section {
      /* background: #dce7eb; */
      /* width: 100%;
    height: 100%; */
      display: flex;
      align-items: center;
    }
    .trash-full {
      animation: trashFullAnimation 1s ease-out infinite;
    }
    .trash-full,
    .trash-full span,
    .trash-full span:after {
      background: ${backgroundFullTrash} !important;
    }
    .trash {
      background: ${backgroundNomarl};
      /* background: #ff6873; */
      width: 66px;
      height: 75px;
      display: inline-block;
      margin: 0 auto;
      z-index: 2;
      position: relative;
      -webkit-border-bottom-right-radius: 6px;
      -webkit-border-bottom-left-radius: 6px;
      -moz-border-radius-bottomright: 6px;
      -moz-border-radius-bottomleft: 6px;
      border-bottom-right-radius: 6px;
      border-bottom-left-radius: 6px;
    }

    .trash span {
      background: ${backgroundNomarl};
      position: absolute;
      height: 12px;
      /* background: #ff6873; */
      top: -19px;
      left: -10px;
      right: -10px;

      border-top-left-radius: 8px;
      border-top-right-radius: 8px;
      transform: rotate(0deg);
      transition: transform 250ms;
      transform-origin: 19% 100%;
      /* animation: shakeLeftRight s ease-in-out; */
    }
    .trash span:after {
      background: ${backgroundNomarl};
      content: "";
      position: absolute;
      width: 27px;
      height: 7px;

      top: -10px;

      border-top-left-radius: 10px;
      border-top-right-radius: 10px;
      transform: rotate(0deg);
      transition: transform 250ms;
      transform-origin: 19% 100%;
      left: 27px;
    }

    .trash i {
      position: relative;
      width: 5px;
      height: 50px;
      background: #fff;
      display: block;
      margin: 14px auto;
      border-radius: 5px;
    }
    .trash i:after {
      content: "";
      width: 5px;
      height: 50px;
      background: #fff;
      position: absolute;
      left: -18px;
      border-radius: 5px;
    }
    .trash i:before {
      content: "";
      width: 5px;
      height: 50px;
      background: #fff;
      position: absolute;
      right: -18px;
      border-radius: 5px;
    }

    .throw-trash span {
      transform: rotate(-45deg);
      transition: transform 250ms;
    }
    .paper-img {
      position: absolute;
      top: -80px;
      right: 0;
      animation: flyIntoTrash 2s ease-in-out forwards;
      display: grid;
      grid-template-columns: auto auto;
      justify-content: center;
      align-items: center;
      z-index: 1;
      .img {
        width: 20px;
      }
    }

    @keyframes flyIntoTrash {
      0% {
        transform: translate(-35px, -10px) rotate(45deg);
      }
      100% {
        transform: translate(-110px, 100px) rotate(0deg);
      }
    }

    @keyframes shakeLeftRight {
      0% {
        transform: rotate(0deg);
      }
      25% {
        transform: rotate(-3deg);
      }
      50% {
        transform: rotate(3deg);
      }
      75% {
        transform: rotate(-3deg);
      }
      100% {
        transform: rotate(0deg);
      }
    }

    @keyframes trashFullAnimation {
      0% {
        transform: scale(1);
        box-shadow: 0 0 10px rgba(0, 0, 0, 0.2);
      }
      50% {
        transform: scale(1.05);
        box-shadow: 0 0 20px rgba(255, 0, 0, 0.5);
      }
      100% {
        transform: scale(1);
        box-shadow: 0 0 10px rgba(0, 0, 0, 0.2);
      }
    }
  }
`;

const TruckWrapper = styled.div`
  /* @keyframes truck-animation {
    0% {
      left: -200px;
      opacity: 1;
    }
    40% {
      left: ${(props) => props.left};
      opacity: 1;
    }
    60% {
      left: ${(props) => props.left};
      opacity: 1;
    }
    100% {
      left: ${(props) => props.maxLeft};
      opacity: 0;
      display: none;
    }
  } */

  .truck-wrapper {
    position: absolute;
    z-index: 10;
    animation: ${(props) => createKeyframes(props.left, props.maxLeft)} 6s
      forwards;
  }

  .truck {
    height: 110px;
    width: 150px;
    /* position: absolute;

    bottom: 48px;
    left: calc(50% + 10px);
    transform: translateX(-50%); */
  }

  .truck > .truck-container {
    background: #6eaa2e;

    filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#afbdc3', endColorstr='#8fa3ad',GradientType=1 );
    height: 60px;
    width: 82px;
    position: absolute;
    top: 14px;
    left: 10px;
    clip-path: polygon(23% 0, 100% 0, 100% 100%, 0% 100%);
    /* animation: container 0.4s linear infinite; */
    .logo {
      width: 100%;
      height: 100%;
      display: flex;
      justify-content: center;
      align-items: center;
      img {
        max-width: 60px;
      }
      .imgshake {
        animation: shake 0.5s;
      }

      @keyframes imgshake {
        0% {
          transform: translate(1px, 0);
        }
        25% {
          transform: translate(-1px, 0);
        }
        50% {
          transform: translate(1px, 0);
        }
        75% {
          transform: translate(-1px, 0);
        }
        100% {
          transform: translate(0, 0);
        }
      }
    }
  }

  .truck > .glases {
    background: #fff;
    /* background: rgb(40, 181, 245);
    background: -moz-linear-gradient(
      -45deg,
      rgba(40, 181, 245, 1) 0%,
      rgba(40, 181, 245, 1) 50%,
      rgba(2, 153, 227, 1) 52%,
      rgba(2, 153, 227, 1) 100%
    );
    background: -webkit-linear-gradient(
      -45deg,
      rgba(40, 181, 245, 1) 0%,
      rgba(40, 181, 245, 1) 50%,
      rgba(2, 153, 227, 1) 52%,
      rgba(2, 153, 227, 1) 100%
    );
    background: linear-gradient(
      135deg,
      rgba(40, 181, 245, 1) 0%,
      rgba(40, 181, 245, 1) 50%,
      rgba(2, 153, 227, 1) 52%,
      rgba(2, 153, 227, 1) 100%
    ); */
    filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#28b5f5', endColorstr='#0299e3',GradientType=1 );
    position: absolute;
    height: 25px;
    width: 25px;
    border: 4px solid #6eaa2e;
    border-bottom: none;
    top: 39px;
    left: 95px;
    border-top-right-radius: 6px;
    /* animation: updown-half 0.4s linear infinite; */
  }
  .truck > .glases:after {
    content: "";
    display: block;
    background-color: #6eaa2e;
    height: 13px;
    width: 10px;
    position: absolute;
    right: -10px;
    bottom: 0px;
    border-radius: 10px / 15px;
    border-bottom-right-radius: 0px;
    border-bottom-left-radius: 0px;
    border-top-left-radius: 0px;
  }

  .truck > .glases:before {
    content: "";
    display: block;
    background-color: #6eaa2e;
    height: 12px;
    width: 16px;
    position: absolute;
    left: 0px;
    bottom: 0px;
    border-top-right-radius: 4px;
  }

  .truck > .bonet {
    background-color: #6eaa2e;
    position: absolute;
    width: 124px;
    height: 15px;
    top: 64px;
    left: 10px;
    z-index: -1;
    /* animation: updown 0.4s linear infinite; */
  }

  .truck > .bonet:after {
    content: "";
    display: block;
    background: rgb(255, 255, 255);
    background: -moz-linear-gradient(
      -45deg,
      rgba(255, 255, 255, 1) 0%,
      rgba(241, 241, 241, 1) 50%,
      rgba(225, 225, 225, 1) 51%,
      rgba(246, 246, 246, 1) 100%
    );
    background: -webkit-linear-gradient(
      -45deg,
      rgba(255, 255, 255, 1) 0%,
      rgba(241, 241, 241, 1) 50%,
      rgba(225, 225, 225, 1) 51%,
      rgba(246, 246, 246, 1) 100%
    );
    background: linear-gradient(
      135deg,
      rgba(255, 255, 255, 1) 0%,
      rgba(241, 241, 241, 1) 50%,
      rgba(225, 225, 225, 1) 51%,
      rgba(246, 246, 246, 1) 100%
    );
    filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#ffffff', endColorstr='#f6f6f6',GradientType=1 );
    height: 10px;
    width: 6px;
    position: absolute;
    right: 0px;
    bottom: 2px;
    border-top-left-radius: 4px;
  }

  .truck > .base {
    position: absolute;
    background-color: #445a64;
    width: 106px;
    height: 15px;
    border-top-right-radius: 10px;
    top: 70px;
    left: 14px;
    /* animation: updown 0.4s linear infinite; */
  }

  .truck > .base:before {
    content: "";
    display: block;
    background-color: #e54a18;
    height: 12px;
    width: 5px;
    position: absolute;
    left: -4px;
    bottom: 0px;
    border-bottom-left-radius: 4px;
  }

  .truck > .base:after {
    content: "";
    display: block;
    background-color: RGB(84, 110, 122);
    height: 10px;
    width: 20px;
    position: absolute;
    right: -16px;
    bottom: 0px;
    border-bottom-right-radius: 4px;
    z-index: -1;
  }

  .truck > .base-aux {
    width: 82px;
    height: 8px;
    background-color: #6eaa2e;
    position: absolute;
    top: 65px;
    left: 14px;
    border-bottom-right-radius: 4px;
    /* animation: updown 0.4s linear infinite; */
  }
  .truck > .wheel-back {
    left: 20px;
  }

  .truck > .wheel-front {
    left: 95px;
  }

  .truck > .wheel-back,
  .truck > .wheel-front {
    border-radius: 100%;
    position: absolute;
    background: rgb(84, 110, 122);
    background: -moz-linear-gradient(
      -45deg,
      rgba(84, 110, 122, 1) 0%,
      rgba(84, 110, 122, 1) 49%,
      rgba(68, 90, 100, 1) 52%,
      rgba(68, 90, 100, 1) 100%
    );
    background: -webkit-linear-gradient(
      -45deg,
      rgba(84, 110, 122, 1) 0%,
      rgba(84, 110, 122, 1) 49%,
      rgba(68, 90, 100, 1) 52%,
      rgba(68, 90, 100, 1) 100%
    );
    background: linear-gradient(
      135deg,
      rgba(84, 110, 122, 1) 0%,
      rgba(84, 110, 122, 1) 49%,
      rgba(68, 90, 100, 1) 52%,
      rgba(68, 90, 100, 1) 100%
    );
    filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#546e7a', endColorstr='#445a64',GradientType=1 );
    top: 80px;
    height: 22px;
    width: 22px;
    animation: spin 0.6s linear infinite;
  }

  .truck > .wheel-back:before,
  .truck > .wheel-front:before {
    content: "";
    border-radius: 100%;
    left: 5px;
    top: 5px;
    position: absolute;
    background: rgb(175, 189, 195);
    background: -moz-linear-gradient(
      -45deg,
      rgba(175, 189, 195, 1) 0%,
      rgba(175, 189, 195, 1) 50%,
      rgba(143, 163, 173, 1) 51%,
      rgba(143, 163, 173, 1) 100%
    );
    background: -webkit-linear-gradient(
      -45deg,
      rgba(175, 189, 195, 1) 0%,
      rgba(175, 189, 195, 1) 50%,
      rgba(143, 163, 173, 1) 51%,
      rgba(143, 163, 173, 1) 100%
    );
    background: linear-gradient(
      135deg,
      rgba(175, 189, 195, 1) 0%,
      rgba(175, 189, 195, 1) 50%,
      rgba(143, 163, 173, 1) 51%,
      rgba(143, 163, 173, 1) 100%
    );
    filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#afbdc3', endColorstr='#8fa3ad',GradientType=1 );
    height: 12px;
    width: 12px;
  }

  @keyframes spin {
    50% {
      top: 81px;
    }
    100% {
      transform: rotate(360deg);
    }
  }

  @keyframes container {
    30% {
      transform: rotate(1deg);
    }
    50% {
      top: 11px;
    }

    70% {
      top: 10px;
      transform: rotate(-1deg);
    }
  }

  .truck > .smoke {
    position: absolute;
    background-color: #afbdc3;
    border-radius: 100%;
    width: 8px;
    height: 8px;
    top: 90px;
    left: 6px;
    animation: fade 0.4s linear infinite;
    opacity: 0;
  }

  .truck > .smoke:after {
    content: "";
    position: absolute;
    background-color: RGB(143, 163, 173);
    border-radius: 100%;
    width: 6px;
    height: 6px;
    top: -4px;
    left: 4px;
  }

  .truck > .smoke:before {
    content: "";
    position: absolute;
    background-color: RGB(143, 163, 173);
    border-radius: 100%;
    width: 4px;
    height: 4px;
    top: -2px;
    left: 0px;
  }

  @keyframes fade {
    30% {
      opacity: 0.3;
      left: 7px;
    }
    50% {
      opacity: 0.5;
      left: 6px;
    }

    70% {
      opacity: 0.1;
      left: 4px;
    }

    90% {
      opacity: 0.4;
      left: 2px;
    }
  }

  @keyframes bg {
    from {
      background-position-x: 0px;
    }
    to {
      background-position-x: -400px;
    }
  }

  @keyframes updown {
    50% {
      transform: translateY(-20%);
    }

    70% {
      transform: translateY(-10%);
    }
  }

  @keyframes updown-half {
    50% {
      transform: translateY(-10%);
    }

    70% {
      transform: translateY(-5%);
    }
  }
`;
export const TrashContainer = styled.div`
  display: flex;
  flex-direction: column;
  align-items: center;
  padding: 10px;
  /* background: #f4f4f4; */
  border-radius: 10px;
  /* box-shadow: 0px 4px 6px rgba(0, 0, 0, 0.1);
  transition: transform 0.2s ease-in-out; */
  /* &:hover {
    transform: scale(1.05);
  } */
`;
export const TrashInfo = styled.div`
  font-size: 14px;
  font-weight: bold;
  color: #333;
  margin-bottom: 5px;
`;

export const TrashBar = styled.div`
  width: 100%;
  height: 10px;
  border-radius: 5px;
  background: ${(props) => props.barColor};
  transition: width 0.3s ease-in-out;
`;

export const TrashImage = styled.img`
  width: 40px;
  height: 40px;
  margin-top: 5px;
`;
export { TrashWrapper, TruckWrapper };
export default MapWrapper;
