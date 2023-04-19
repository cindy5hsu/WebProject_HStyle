# H'Style Luxury Fashion Platform
#### Our aim is to provide a platform for fashion enthusiasts to purchase high-end premium products. We offer a fashion blog with articles and videos for outfit inspiration, as well as the publication of the most exquisite and influential magazine. Our website provides personalized weather-based recommendations for outfit ideas and an online shopping platform.

# Technologies Used
#### 1. Backend: ASP.NET MVC
#### 2. Frontend: .NET Core Web API + Vue
#### 3. Database: SQL Server
#### 4. Data Access Technology: Entity Framework
#### 5. Third-Party API Integration: PayPal, Central Weather Bureau
#### 6. Communication Protocol: WebSocket

# Back-end

![img](https://github.com/cindy5hsu/WebProject_HStyle/blob/master/SQL%20server/search.gif)

* Three-tier architecture
* Interface implementation in a repository
* Extension methods for ToVM and ToDTO conversions
* Private access modifier in a controller for data storage
* Constructor injection for initialization

# Add a new blog post

![img](https://github.com/cindy5hsu/WebProject_HStyle/blob/master/SQL%20server/create.gif)

* Content Encryption and Image Encoding with CKEditor
  * Utilized CKEditor as an editor to prevent code injection and HTML tags in the content
  * Encrypted the content with a secure algorithm before storing it in the database to prevent attacks
  * Used base64 encoding to encode images in the content
  * Decoded the base64-encoded images before rendering the content on the website

# Daily scheduled tasks

![img](https://github.com/cindy5hsu/WebProject_HStyle/blob/master/SQL%20server/daily%20update.png)

* Scheduling the promotion, video, and article releases
* Using the built-in Windows Task Scheduler to schedule the daily promotion, video, and article release tasks
* The built-in Windows Task Scheduler runs daily and strictly follows the specified publish and unpublish times for releases.
