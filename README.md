# [Final ReadMe](https://github.com/ncf00003/LogisticsWebApplication/blob/main/FinalReadMe.md)

# [Assignment 5 ReadMe](https://github.com/ncf00003/LogisticsWebApplication/blob/main/PrototypeWebApplication/ReadMeA5.md)


# [APIs ReadMe](https://github.com/ncf00003/LogisticsWebApplication/tree/main/LogisticsWebAppAPI#readme)

# PrototypeWebApplication
### Project Overview
We plan to create a web app based on dynamic routes for logistics (shipping) companies. 
<p> This is our basic prototype with background research. We aim to make a visually appealing overview
of shipping times, routing, and tracking information. 
</p>

### Future Enhancements
<p> Crucially, this web applicaiton will need a creative name in the future. Outside of visual aspects which will improve as we work,
we need to continue improving functional aspects on our pages. 
</p>
<p> Front-end considerations are more visually appealing pages including relevant graphic. Additionally, we aim to add more interactive features around logistics routes, tracking, schedules. Back-end considerations are inclusion of a database and further information so users will be able to search specific information easily.</p>

# Collective Research Findings
## Natalia Furmanek 
<strong> 1. Competitive Development </strong>
<br> https://www.fluentcargo.com/ is a similar website to what we plan on creating.</b>
<p> Fluent Cargo has a sleek design with multiple buttons that can direct user attention, plus some ideas for what needs to be included on our web app. There is a search bar that I want to include plus directional buttons for routes, tracking, schedules and ports. The website itself is full of eye catching and moving visuals. At the bottom of the page, there is information about popular shipping routs which would be useful to include for our app; although, I would place this on a seperate page for our project.</p>
<p> After inspecting the website to see its code Fluent Cargo appears to be using custom classes for each header or block of information. Looking to sources, it appears that the site uses DatoCMS assets to assist in collaboration on the site and JS Stripe to accept secure payments. As for Bootstrap, the closest source file I could find was labeled globals.css. Under theme, there were only .ts files which may explain the moving graphics and videos throughout the site. </p>
<p> Overall, Fluent Cargo is a good source of functional inspiration but the design aspects are not. The design is very visually appealing but it often takes a while to load on the user end which we would want to avoid. Plus, inspection of the site with browser tools revealed that many sources and elements are beyond our scope for this project. With this project, advanced graphics and file types used to create this website are not as benefical for our efforts as the core functions of the site.
</p>

<strong> 2. GitHub Repository Research </strong>
<br> https://github.com/karrioapi/karrio is a Shipping web application repository that may be benefical to our project </b>
<br> Additionally, This project uses the Apache v2 license </b> 
<p> Karrio is a public open-source repository, comprised mainly of Python code but contains Javascript and CSS that we can better understand from class coverage.
The ReadMe file is visually appealing and outlines how to get started on the app alongside great detail of capabilities and shipping integration limitations. Some aspects of this repository that we may want to implement are: label generation, package tracking, and document generation. The website itself runs quickly and makes use of color blocks and minimal graphics.</p>
<p> Finally, Karrio clearly defines user and admin capabilities which could be an interesting aspect to borrow in our logistics web application. Karrio specifies that this is a developer resource, so it is appropriate for our project efforts. Although, in using this code, we need to keep in mind the limitations and use of Python which we have not covered in class yet.  
</p>
 
<strong> 3. Prototype Development </strong>
<br> I created the Start Here (Welcome.cshtml) page, I also modified the Index.cshtml page to match. </b> 
<p> Created and shared repository alongside initial ReadMe format </p>
<p> Added Minty Bootswatch theme into project design </p>
<p> Git Changes trouble shooting to fix push and branch errors </p>
<p> Added "Welcome" page that was named "Start Here" on the navigation bar. Also added visuals with alt. text to both pages for cohesion of pages. "Start Here" will include overview and about information which may change as we narrow down ideas for our websites function and a table for team information. Created a CSS "box" as a style option used for blocking paragraphs together on my page. Team table created with name, role and class information about group members. Table was formatted using bootstrap and custom style to blend in with CSS box and add unity. Added Javascript element to hide the team table and to make the table re-appear on the Welcome page.
</p>
 
<strong> 4. Resources </strong>
<br> https://bootswatch.com/minty/ </b>
<br> Bootswatch used for style sheet and Bootstrap templates </b>
<p> https://www.markdownguide.org/basic-syntax/ <br>
Markdownguide used as a format reference </b> </p>  
<p> https://www.w3schools.com/bootstrap5/bootstrap_containers.php <br>
https://getbootstrap.com/docs/5.3/content/tables/#bordered-tables </b> <br>
</b> Both Websites used as syntax reference for Bootstrap Elements </b>
</p>
<p> Google's color picker for Custom CSS Color Hex Codes </p>

## Leonardo Cuellar
<strong> 1. Competitive Development </strong>
<br>Samsara is a fleet management system that provides estimated route times for logistics companies.</b> 
<p>The software uses weather data (from the weather channel) to calculate delivery times and enables real-time trailer tracking. It also integrates data from environmental monitoring hardware to update estimated times and distances during transit. However, the software apparently doesn't use historical data to refine estimations or offer a dynamic quoting system for logistics companies to enhance productivity and improve quotes. The site offers Software as a Service (SaaS) solutions and seems to be built with Vue.js for the front-end. Buttons and other elements use Bootstrap naming conventions, and I found 22 CSS files with custom Bootstrap styling.</p>

<strong> 2. GitHub Repository Research </strong>
<br>[Fleetbase](https://github.com/fleetbase/fleetbase?tab=readme-ov-file#-features) is an open-source modular logistics and supply chain operating system (LSOS).</b> 
<p>Being open-source gives us the advantage of accessing specific scripts and having a good base of what the market currently uses. It also has a driver app, ensuring we address not only our primary customer (the logistics company) but also the drivers. As a finalized, customer-facing product, it's frequently updated by the community and includes the latest industry features. It's developed in containers, which is a plus as we can see how these business applications work and operate, offering infinite scalability. It also has dashboard creation functionality for visibility into operations. I think it's an all-encompassing GitHub repository we can refer to when we need direction, scope, or more features for the web application.</p>


<strong> 3. Prototype Development </strong>
<br>I developed the Privacy Policy (Privacy.cshtml) page.</b>
<p>I developed the Privacy Policy page. Although it's automatically added to the navigation by the .NET application, I believe it's crucial for any business. In creating this page, I used h2 and h3 headings. I should disclose that I used ChatGPT to generate sample text for the policy at this stage. When the web app goes to market, we'll update it to ensure customers understand what data and information we collect.</p>
<p>I added IDs to the headings for later reference in the table of contents. For the table of contents, I created a table with headers and added links to different sections of the privacy policy in the rows. I used a divider with a class to add custom CSS to the table of contents. As mentioned in Tuesday's class, ChatGPT is really good with CSS!</p>
<p>Additionally, I added a button with the Bootstrap button class "btn-outline-secondary". This button's function is to hide or show the table of contents, providing users with a more interactive experience.</p>

<strong> 4. Resources </strong>

<br>ChatGPT</b>
<p>Prompt 1: Make a sample privacy policy for a Web Application that makes dynamic quotes for logistic companies based on weather data from the locations in the route.</p
<p>Prompt 2: How can I style nicely the table of contents for this privacy policy using HTML and CSS?</p>
<p>I also used Notion AI's "improve writing" feature, powered by ChatGPT, to enhance the paragraphs in this readme and better organize my ideas.</p>
<p>The resources consulted during this assignment were invaluable in creating a cohesive, user-friendly, and interactive page. Leveraging generative AI proved particularly useful for styling the page and establishing a solid foundation for the Privacy Policy—an essential component of any application.</p>

[W3schools](https://www.w3schools.com/html/html_tables.asp)
[Codecademy Markdown](https://www.codecademy.com/resources/docs/markdown/links)

## Luke Chittenden
<strong> 1. Competitive Development </strong>
<br>[FreightQuote](https://www.freightquote.com/track-shipment/) allows the user to track their shipments by entering their BOL number in a search engine to get instant freight tracking information.</b>
<p>The main search bar is on the homepage along with some options above. On the top of the main page there are three dropdown options that allows the user to navigate and filter through the different results. For example there is an option to search for just Canadian shipments, and a way to search specific sized shipments. There is another option that directs the user to different pages that explain how the supply chain system works, allowing users to learn about the shipping/trucking industry. Finally, there is a shortcut to the websites rewards program page. This lets users sign in and receive rewards depending on how much the website is used or what it is used for.</p>
<p>After sifting though the websites code, I was able to find some different functionalities that the website utilizes. The main search bar has a button that uses the placeholder and onclick attributes in order to let the user run the search engine for whatever information they may need from the website. The CSS class for the button as well as the search bar allow me to see the height, width, color, display type, etc. When inspecting the header of the website, it shows the different classes used for each button and dropdown menu. It reveals each image source used for each icon, including the sign in and the website logo icon. Though after looking through the code, I was not able to find any evidence for bootstrap usage.</p>

<strong> 2. GitHub Repository Research </strong>
<br>[Abuad Deliveries](https://github.com/OmoruyiOhuoba/ABUAD-DELIVERIES) allows users to perform operations that manage/track different couriers and parcels.</b>
<p>This repository utilizes three different user groups. Admins, customers, and drivers. It has custom built API’s to delete different couriers, or update their orders. There is a login function with a database of users. Each user has information linked to them including their address, name, mobile number, etc. The website also generates a consignment number during the billing process for each product. The website also has a delivery system that shows users where a current consignment is, how long it will take to reach its destination, and a final date of arrival. You are also able to update the status of a consignment if it is not delivered on time.</p>

<strong> 3. Prototype Development </strong>
<br>I developed the Learn page dedicated to informing the user about the ins and outs of parcel shipping</b> 
<p>A page dedicated to explaining how parcel shipping works is essential for a web app like ours. It serves to help users learn about the complexities of shipping, such as estimated delivery times, shipping zones, and tracking processes. This helps improve user confidence and reduces confusion. By listing common questions like shipping times and tracking numbers, the page is able to reduce the number of customer support inquiries. Not only does this help the user with confusion, it also fosters trust, as users gain a better understanding of what happens with their shipments.</p>

<strong> 4. Resources </strong>

<br>ChatGPT</b>
<p>Prompt: I am creating a webpage that aims to make a visually appealing overview of shipping times, routing, and tracking information. Write some information about parcel shipping that focuses on teaching new users how it works.</p>
<p>[W3Schools - Tables](https://www.w3schools.com/html/html_tables.asp)</p>
<p>[W3Schools - Formatting](https://www.w3schools.com/html/html_formatting.asp)</p>
<p>[Markdown]https://www.markdownguide.org/basic-syntax/</p>
<p>I also used my teammates material as a reference to support my work.</p>
