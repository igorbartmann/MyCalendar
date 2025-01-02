# MyCalendar

- [Project Details](#project-details)
- [Project Architecture](#project-architecture)
- [Host Process](#host-process)
- [Use Cases](#use-cases)
- [Prototype](#prototype)
- [Development Tasks](#development-tasks)

## Project Details
Project: MyCalendar.


Description: This project offers a web app which you can share notes and calendar events with your friends.

## Project Architecture
The project architecture was divided into 3 layers:
- Frontend: Angular
- Backend: Asp .Net Core
- Database: Microsoft Sql Server (MSSQL)

## Host Process
The host process still needs to be defined, but we're thinking of something like:
- Docker
- Hostinger VPS

## Use Cases
As an user, I can
- Create Account (signup): by click accessing Login screen and clicking in 'Criar Conta' button. A new screen will open and I must to fill all fields with data as: Name, Birth data, E-mail and password. When all fields was filled, I can click in 'Cadastrar' button to create my account.
- Confirm Account: after realize 'Create Account' step, I will receive an e-mail with a link to confirm it. When I click in the link, my account will be automaticly activated and I will be redirect to Home page already logged in the MyCalendar app.
- Change User Photo or Name: accessing Home page, I can click in edit icon (next to my user photo) and edit both my user photo and user name. After edit, I can save the new informations by click in 'Salvar' button.
- Vizualize Messages: at Home screen, I can view received messages by click in message icon, on the upper right message icon. Remember, it shows to me the number of non readed messages received. Note that I always receive new messages when: I change some profile data, I receive a share request from another user or another user accept a share request that I sent.
- Create request to share informations with other users: at Home screen, I can request to share informations with other users by clicking in 'Novo Compartilhamento' button, selecting the users and clicking in 'Enviar solicitação' button.
- View my shares: at Home screen, I can visualize all my shares.
- View informations shared with other users: at Home screen I can click in a share retangle area to visualize the informations shared in this area of users. After click in the retangle area, the Compartilhamento screen will open and I can select 'Calendário' (calendar) or 'List' (list) to see informations.

## Prototype
Login Page <br/>
[]

SignUp Page <br/>
[]

Home Page <br/>
[]

Home Page + Edit Profile Modal <br/>
[]

Home Page + Notifications Modal <br/>
[]

Home Page + New Share Modal <br/>
[]

Share Page <br/>
[]

Share Page + Edit Shared Area Description Modal <br/>
[] 

Calendar Page <br/>
[] 

List Page <br/>
[] 

## Development Tasks
Tasks to do:

**1) Create All Projects Base.**

**2) Save the projects in GitHub.**

**3) Add this text as readme.md**

**4) Database Project.**
> a)   Create User table: Id(int), Name(string-50), BirthDate(datetimeoffset), Email(string-100), Password(string-30), Photo(string-100), Blocked(bit), SecurityGuid(guid). => This table must heve historic.
>
> b)  Create Email table: Id(int), From(string-100), To(string-100), Title(string-30), Message(string-150), Status(enum-1=queue, 2=sent,3=canceled).
>
> c) Create Notification table: Id(int), UserId(FK_User_id), Message(string-50), Readed(bit).
>
> d)  Create SharedArea table: Id(int), Description(string-50).
>
> e)   Create SharedAreaUser Table: Id(int), SharedArea(int - FK_SharedAreaUser_SharedArea), UserId(int - FK_SharedAreaUser_User).
>
> f)  Create CalendarEvent table: id(int), SharedAreaId(int - FK_SharedAreaCalendarEvent_SharedArea), Date(datetimeoffset), title(string-20), description(string50).
>
> g) Create List table: id(int), SharedAreaId(int - FK_SharedAreaListTable_SharedArea), Description(string-50), Order(int), Done(bit).

**5) Backend Project.**
> a) Create Entities.
>
> b) Create Repositories.
>
> c) Context.
> 
> d) ContextOptionsConfiguration.
>
> e) Create Queries.
>
> f) Create Services.
>
> g) Create Validators.
> 
> h) Create Controllers.
> 
> i) Add Authorization (by JWT Bearer Token).
 
**6) Frontend Project.**
> a) Create Login Screen.
> 
> b) Create Signup Screen.
> 
> c) Create Home Screen.
> 
> d) Add Messages modal to Home Screen.
> 
> e) Add Share Request Modal to Home Screen.
> 
> f) Create Shared Screen.
> 
> g) Create Calendar Screen.
> 
> h) Create List Screen.
