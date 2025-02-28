Garbage traffic control system

1. Overview of the project.
1.1. Idea: Control garbage traffic
Objective
The goal of this project is to enhance waste management efficiency in tourist destinations by leveraging AI-powered video solutions to monitor and optimize trash bin usage. This system aims to improve cleanliness, reduce overflow incidents, and support sustainable practices in high-traffic areas. By ensuring timely waste collection and minimizing unnecessary labor, the solution promotes a better visitor experience and supports eco-friendly venue operations.
Implementation
The solution will utilize AI-driven cameras strategically placed to monitor trash bins throughout the tourist site. These cameras will detect trash-dumping actions and track the number of deposits in real time. Each bin will have a predefined capacity (e.g., 100 trash-dumping actions) and its fill level will be represented on an interactive map of the site.
Key features include:
Dynamic Fill Level Monitoring: 
The Dynamic Fill Level Monitoring system visually represents the trash bin status using a color-coded progress bar. Initially, when a bin is empty, the status bar appears fully green. Each time trash is added, the green portion decreases while a red section gradually replaces it, indicating the increasing fill level. Once the bin reaches full capacity, the status bar turns completely red, and the bin icon on the map begins to vibrate, ensuring easy detection by the cleaning team. This real-time visual cue helps streamline waste collection efforts without requiring additional notifications.
Interactive Visualization: 
An intuitive map interface will show bin locations and fill levels, enabling easy navigation for the cleaning crew.
Alert System: 
When a trash bin reaches its maximum capacity, the system will display a visual alert on the interactive map. The full bin will be represented with a blinking red icon on the map, making it easy for the cleaning team to identify and promptly collect the trash, thus avoiding overflow without the need for phone or app-based notifications.
The system will leverage the Nx Toolkit for video analytics and the Nx AI Manager for real-time detection and data aggregation. Open-source tools and APIs will be used to integrate camera feeds, map visualization, and alert mechanisms.
Applications
This solution is designed for tourist sites, theme parks, and public spaces where efficient waste management is critical. Beyond tourist areas, the system can be adapted for urban environments, stadiums, and event venues to enhance waste collection efficiency and support sustainability goals.
Final Result
The project’s outcome will be a fully functional prototype that visualizes waste levels across a tourist site in real-time. The system will streamline waste management, reducing operational costs and enhancing site cleanliness. By improving service efficiency, the solution will contribute to better visitor satisfaction and more sustainable operations.
Post-Campaign Plans
After the hackathon, this idea will be further developed by incorporating additional features such as:
Predictive analytics to forecast bin usage patterns based on historical data.
Integration with IoT-enabled smart bins to detect fill levels without relying solely on action counts.
Expansion to monitor recycling bins, enabling data-driven insights for waste segregation.
The long-term goal is to commercialize the solution and collaborate with municipalities, private venues, and sustainability initiatives to make it a scalable, real-world application with significant market potential.

1.2. Garbage traffic control system
The system consists of two main parts:
NX Meta Server:
- Operating System: Linux
- LAN IP: 192.168.100.6, port 7001. Accessible via the Internet at 113.190.240.90:7001
- Installed Software: NX Meta Server, NX AI Manager
- Connects cameras through NX Meta Server
CMS System:
CMS includes API, Socket, and Frontend
API and Socket are built using .NET technology
Frontend is developed with ReactJS
Both API and Frontend are publicly available at the domain nx.gosol.com.vn




2. Installation guide.
2.1. Path of built project components
- CMS: https://github.com/anhvh1/Control-garbage-traffic/tree/main/Public
- Database: 
- Model: https://github.com/anhvh1/Control-garbage-traffic/blob/main/Control%20garbage%20traffic.tm
2.2. Frameworks, Device
- Nx Meta, Nx Ai Manager, Teachablemachine
- Frontend: Frontend uses Reactjs, Websocket
- Backend: .NET 8, Microsoft SQL Server 2014, ASP.NET Core Web API
- IP Camera
2.3. Set up the server and environment.
Step 1: Install the Ubuntu operating system.
Step 2: Update the system, install SSH, and the dependent packages.
Step 3: Download the Nx Meta Server file and save it to the Downloads folder.
Step 4: Use sudo dpkg -i <file.deb> and handle dependency errors with sudo apt-get install -f.
Step 5: Use `sudo systemctl status networkoptix-mediaserver` and check the ports (7001, etc.).
Step 6: Download and install the plugin, then restart the service and check the logs.
Step 7: Add the camera to the Nx Meta system through the client interface, entering the IP information, port, and protocol.
2.4. Training and public model 
- Use Teachablemachine to train the model 
- Public model on NX Cloud 
- Add Model to Camera
2.5. Public cms to host 
Step 1: Build code (You can use the pre-built code available on GitHub as guided in section 2.1 of this document.)
Step 2: Create website with domain name "nx.gosol.com.vn." (you can use your own domain)
- The built code of the project is placed in a directory that contains the complete API code, along with a "Client" folder that includes all the frontend code..


2.6. Install the camera.
- Place the camera in suitable locations to monitor your trash can
- Configure the camera and log in to your camera account
- Configure the camera to connect to the API:

Step 1: Select the camera to install
Step2: Configure the corresponding class in the Description contains section, there are 2 classes xarac, none.
Step 3: Configure using HTTP(S), attach URL and configure content according to fields: https://nx.gosol.com.vn/api/v1/Nx/Log (You can use it according to the domain you have published in section 2.4.)
+ "Code": Corresponds to camera id (We are configuring 10 cameras starting from CM001 to CM010)
+ "Type": Corresponding to the above 2 classes: 1 (throw garbage in the bin), 2 (None) respectively,


3. User guide.
- Cccess the website link https://nx.gosol.com.vn to monitor the state of the trash cans (Go to the path you set in section 2.5)
- Every time someone throws trash in the bin, the camera will detect and send a signal to the system via socket, immediately after that the status of the bin will be updated on the map.

