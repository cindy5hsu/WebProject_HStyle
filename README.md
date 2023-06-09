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

# New Blog post

![img](https://github.com/cindy5hsu/WebProject_HStyle/blob/master/SQL%20server/create.gif)

* Content Encryption and Image Encoding with CKEditor
  * Utilized CKEditor as an editor to prevent code injection and HTML tags in the content
  * Encrypted the content with a secure algorithm before storing it in the database to prevent attacks
  * Used base64 encoding to encode images in the content
  * Decoded the base64-encoded images before rendering the content on the website

# Daily Scheduled Tasks

![img](https://github.com/cindy5hsu/WebProject_HStyle/blob/master/SQL%20server/daily%20update.png)

* Scheduling the promotion, video, and article releases
* Using the built-in Windows Task Scheduler to schedule the daily promotion, video, and article release tasks
* The built-in Windows Task Scheduler runs daily and strictly follows the specified publish and unpublish times for releases.

# H'Style Luxury Fashion Platform 

![img](https://github.com/cindy5hsu/WebProject_HStyle/blob/master/SQL%20server/website.gif)

* The header is set to stick to the top and scroll with the page.
* Home page features slide images and fixed elements for a unique visual effect.
* Floating images added to article cards when hovering over them.
* Titles are set to display only a specified length.
* Date is displayed at the bottom of each card, and registered users can bookmark individual content.

# Blog Website Homepage

![img](https://github.com/cindy5hsu/WebProject_HStyle/blob/master/SQL%20server/blogepage.gif)

* Homepage features a Bootstrap carousel and displays the latest four articles and videos.
* The page is divided into three columns to create a distinctive visual effect. The left column features an image that scrolls in sync with the page, while the right two columns scroll normally.
* The columns listen to the container element's scroll event and obtain the scrolling distance using scrollTop.

# Favorites, Reviews, and Product Recommendations

![img](https://github.com/cindy5hsu/WebProject_HStyle/blob/master/SQL%20server/like%26comment.gif)

* Bookmarks: Users must log in to bookmark their favorite articles. All bookmarks can be viewed by clicking on the "Bookmarks" button in the top right corner.
* Product Recommendations: When viewing an individual article, recommended products will continuously scroll to the bottom of the page as the user navigates.
* Comments: A comment section is available below each article for users to provide feedback and engage with other readers. Users can also like comments that they find helpful or interesting.
