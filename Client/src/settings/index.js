const date = new Date();
const currentYear = date.getFullYear();
export default {
  v2Url: "https://nx.gosol.com.vn/api/v1/", // api
};
const siteConfig = {
  siteName: "NX Map",
  siteIcon: "", //ion-flash
  footerText: `Copyright © ${currentYear} GO SOLUTIONS. All rights`,
};

const themeConfig = {
  topbar: "theme6",
  sidebar: "theme8",
  layout: "theme2",
  theme: "themedefault",
};

export { siteConfig, themeConfig };
