import { apiPost } from "../../api";
import server from "../../settings";
const apiUrl = {
  cleartrash: server.v2Url + "NxLog/Log",
};

const api = {
  ClearTrash: (param) => {
    return apiPost(apiUrl.cleartrash, { ...param });
  },
};

export default api;
