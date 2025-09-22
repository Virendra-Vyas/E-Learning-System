# E-Learning-System

Project Guide on my Blog: - https://virendra.tech.blog/2019/01/27/my-c-projects/

### Table of Contents

- [Description](#description)
- [How To Use](#how-to-use)
- [Author Info](#author-info)

---

## Description

 - This System is a simplified version of the Student Management System in [Three-tier Architecture (Multi-tier)](https://www.jinfonet.com/resources/bi-defined/3-tier-architecture-complete-overview/).
 - This System is in very Understandable format, in which anyone can understand how this system works.
 - There are main two entities in this System Student and Tutor.
 - This System is very useful to those people who are newbies with C# language.
 - I describe all the information in this article with images.

#### Prerequisites

- [Visual Studio 2012](https://visualstudio.microsoft.com/) or above
- [MS SQL Server 2012](https://www.microsoft.com/en-gb/download/details.aspx?id=29062) or above
- [ASP.NET Framework 4.5](https://www.microsoft.com/en-gb/download/details.aspx?id=30653) or above

[Back To The Top](#read-me-template)

---

## How To Use

1. Clone or download this repository.
2. Open `ELearning.sln` in Visual Studio.
3. Update the connection string in `Web.config` to point to your SQL Server instance.
4. Build and run the project (F5).
5. Register as a student or log in with existing tutor/student credentials.

---

## Deployment

#### A step by step guide that tells you how you can deploy this project in your system.

```
1. Open Microsoft SQL Server and create a new database.
2. Run the provided SQL scripts to create the `Users`, `Courses`, `Modules`, and `UserRoles` tables.
3. Update the connection string in `ELearning/Web.config` to your database name and credentials.
4. Open `ELearning.sln` in Visual Studio and build the solution.
5. Press F5 to run the web application locally.
```

**List of Forms & Classes I made in this System**

1. Table Data (Students)
2. Table Data (Tutors)
3. UserLogin.aspx
4. Logout.aspx
5. StudentDetails.aspx
6. TutorDetails.aspx
7. UserAccount.aspx
8. StudentRegistration.aspx
9. UpdatePassword.aspx
10. UpdateTutorCourse.aspx

**#1. Table Data (Students)**

![Table Data](https://virendratech.files.wordpress.com/2019/02/table-data-students.png)

- This table above shows the student records in the database.

**#2. Table Data (Tutors)**

![Table Data](https://virendratech.files.wordpress.com/2019/02/table-data-tutor.png)

- This table shows the tutor records in the database.

**#3. UserLogin.aspx**

![User Login](https://virendratech.files.wordpress.com/2019/02/login.png)

- This login form allows users to authenticate as a student or tutor.

**#4. Logout.aspx**

![Logout](https://virendratech.files.wordpress.com/2019/02/logout-1.png)

- This page asks the user to confirm logout.

**#5. StudentDetails.aspx**

![Student Details](https://virendratech.files.wordpress.com/2019/02/students-details.png)

- Visible to users logged in as students.
- Displays the student’s course, associated tutors, and course modules.

**#6. TutorDetails.aspx**

![Tutor Details](https://virendratech.files.wordpress.com/2019/02/tutor-details.png)

- Visible to users logged in as tutors.
- Displays the tutor’s course and enrolled students.

**#7. UserAccount.aspx (Student View)**

![Student Account](https://virendratech.files.wordpress.com/2019/02/user-account.png)

- This page appears when a student logs in.
- Students can view their details and update their password.

**#8. UserAccount.aspx (Tutor View)**

![Tutor Account](https://virendratech.files.wordpress.com/2019/02/tutor-account.png)

- This page appears when a tutor logs in.
- Tutors can view their details, update their password, and change their course.

**#9. StudentRegistration.aspx**

![Student Registration](https://virendratech.files.wordpress.com/2019/02/student-registration.png)

- Allows users to register as students by default.

**#10. UpdatePassword.aspx**

![Update Password](https://virendratech.files.wordpress.com/2019/02/update-password.png)

- Enables users to update their password.

**#11. UpdateTutorCourse.aspx**

![Update Tutor Course](https://virendratech.files.wordpress.com/2019/02/update-tutor-course.png)

- Allows tutors to change their course directly from their account.

---

## License

```
This Project is licensed under MIT License

Copyright (c) [2019] [Virendr Vyas]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```

[Back To The Top](#read-me-template)

---

## Author Info

- **LinkedIn - [virendra-vyas](https://www.linkedin.com/in/virendra-vyas/)**
- **Website -  [Virendra's Tech](https://virendra.tech.blog)**

[Back To The Top](#read-me-template)