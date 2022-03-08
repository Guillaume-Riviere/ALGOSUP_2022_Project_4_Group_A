---



Table of Contents

- [1. Introduction](#1-introduction)
  - [A. Context](#a-context)
  - [B. Technologies used](#b-technologies-used)
  - [C. Provided files](#c-provided-files)
- [2. Organisation](#2-organisation)
  - [A. Folders](#a-folders)
  - [B. Way of coding](#b-way-of-coding)
  - [C. Github](#c-github)
- [3. Glossary](#3-glossary)
  - [B3](#b3)
  - [CNAM](#cnam)
  - [Scenario](#scenario)
  - [Softskills](#softskills)
  - [Staff](#staff)
  - [Vierzon](#vierzon)
  - [Virtual Simulation](#virtual-simulation)
  - [VR](#vr)
- [4. Furnitures](#4-furnitures)
  - [A. Rooms](#a-rooms)
    - [a. Project Rooms](#a-project-rooms)
    - [b. Meetings Room](#b-meetings-room)
    - [c. Resting Rooms](#c-resting-rooms)
    - [d. Robotic Room](#d-robotic-room)
    - [e. Office Rooms](#e-office-rooms)
    - [f. Language Rooms](#f-language-rooms)
    - [g. Softskills Room](#g-softskills-room)
    - [h. Library Room](#h-library-room)
    - [i. Reception Room](#i-reception-room)
    - [j. Bathrooms](#j-bathrooms)
    - [k. Stock Rooms](#k-stock-rooms)
    - [l. Secured Stock Room](#l-secured-stock-room)
    - [m. Back Outside Deck](#m-back-outside-deck)
    - [n. Front Outside Deck](#n-front-outside-deck)
    - [o. Amphitheater](#o-amphitheater)
    - [p. Reprography](#p-reprography)
  - [B. Halls](#b-halls)
    - [a. Drone Zone](#a-drone-zone)
    - [b. Flight Zone](#b-flight-zone)
    - [c. Stands Zone](#c-stands-zone)
    - [d. Robotic Parkour](#d-robotic-parkour)
    - [e. Greener](#e-greener)
- [5. Working Systems](#5-working-systems)
  - [A. Permission Card](#a-permission-card)
  - [B. Door locks](#b-door-locks)
  - [C. Turnstile](#c-turnstile)
  - [D. Ambient sounds](#d-ambient-sounds)
- [6. Pathfinding](#6-pathfinding)
  - [A. Project room](#a-project-room)
  - [B. Amphitheater](#b-amphitheater)
  - [C. Language room](#c-language-room)
  - [D. Robotic room](#d-robotic-room-1)
  - [E. Resting room](#e-resting-room)
  - [F. Softskills room](#f-softskills-room)
  - [G. Library](#g-library)
  - [H. Bathrooms](#h-bathrooms)
  - [I. Entrance](#i-entrance)
  - [J. Back outside deck](#j-back-outside-deck)
- [7. Pre-made scenario](#7-pre-made-scenario)


---

# 1. Introduction
## A. Context

This project is a Simulation of a school.

It is for the school ALGOSUP, based in Vierzon. This school is a computer sciences school that use neuro-sciences to provide the most efficeint scholarship.

For August/September 2023 than plan to relocate in the center of Vierzon, in old building. This building was used by Case almost 30 years ago.

They still have the possibility to ask for changes for the incoming work. So they decided to ask for a Simulation of the new school in order to be sure everythings was well designed.

So we got asked to make that Simulation with differents scenario when you can see what could append in the school, and what could have been wrongly designed.

That way changes could be applied based on the result we could get.

## B. Technologies used

**Unity**
We use unity in order to be able to generate the 3D simulation in the VR headset.

**C# Language**
C# language is directly linked to Unity, it's the scripting language associated with unity.

**Blender**
Blender is a free 3D design software. It's made so we can edit 3D file, or create new one with tools that Unity doesn't have.

**Github**
Github is a plateform we use to work with a team. It's allow us to have the same project and differents computer


## C. Provided files

The client gave us some files to begin with.
- Drawings of the 1st floor as **PDF**
- Drawings of the 2nd floor as **PDF**
- Drawings of the basement as **PDF**
- 3D Preview file of the B3 as **BIMX**
- 3D file of the B3 as **IFC** converted to **FBX**

# 2. Organisation
## A. Folders


- Assets
  - 3D_File
    - Furnitures
      - ProjectRooms
      - MeetingsRooms
      - Offices
      - RestingRooms
      - RoboticRoom
      - LanguageRoom
      - SoftSkillRoom
      - Library
      - Bathromms
      - StocksRooms
      - Outside
      - Amphitheater
      - Reprography
      - DroneZone
      - RoboticTrack
    - Plants
    - Miscellaneous
  - Materials
    - Furnitures
    - Plants
    - Miscellaneous
  - Animations
  - Scripts


## B. Way of coding

| What  | How | Exemple |
| :---------- |:-----:| :----- |
|Namespace | Lowercase | System |
|Class | Normal| Pathfinder |
|Constructor | Normal | Pathfinder(x,y) |
|Function | PascalCase | FindFastestWay() |
|Variable | camelCase | fastestWay() |
| | -- | |
|3D Files | Snake_Case + PascalCase | Project_Table |
|Folders | PascalCase | ProjectRoom3D |


## C. Github

# 3. Glossary
## B3
The B3 used to belong to the Société française de matériel agricole et industriel (SFMAI), now Société française de Vierzon (SFV), which was a French company created on October 15, 1847 by Célestin Gérard in Vierzon, formerly a French pioneer in agricultural machinery. On February 4th, renovation work began in order to accommodate various institutions such as ALGOSUP, the CNAM, the Connected Campus and a start-up incubator in 2023.

## CNAM
The CNAM (for Conservatoire national des arts et métiers) was created by Abbé Grégoire. It collected newly invented tools, machines and models and explained their operation. Today, the CNAM is established throughout France and in 2021, has obtained the Qualiopi quality certification and renewal of the RSO Lucie label.

## Scenario
Scenario are here to show pre-created events that can happend. It can be the choice of a personae, simulation of lunch-time, simulation of break times...

## Softskills
Soft skills refer to human and personality-related qualities. They are often referred to as emotional intelligence. Empathy, listening and analysis are examples of non-technical skills. They are opposed to hard skills (or technical skills) which are acquired through learning at school or through professional experience. 

## Staff
The Staff is here to help you. They give you permission and they manage the life in the institution.

## Vierzon
Vierzon is a little city in the center of France. It's where the B3 is located.

## Virtual Simulation
The main goal of a virtual simulation is to anticipate things that can happend in real life. In this project for example, we have to careful about personae, time, crowd, etc... which can happend easily.

## VR
VR is a simulated world that can be similar to or completely different from the real world. In that case, closest to reality, better it will be.
VR is simulated using a Headset that the user have to wear to visit the simulation.




# 4. Furnitures
## A. Rooms
### a. Project Rooms

- 1 rectangle table (https://www.cgtrader.com/free-3d-models/interior/interior-office/walnut-raiseable-desk)
- 6 chairs (https://www.cgtrader.com/free-3d-models/furniture/chair/chair-4b4a68cb-33a7-4155-a411-0127a9d4e1cf)
- 1 TV or big screen (https://www.cgtrader.com/free-3d-models/interior/hall/sony-led-tv-f3edc673-2c3b-4767-a062-ed2179c04f20)
- 1 whiteboard or digital whiteboard (https://www.cgtrader.com/free-3d-models/architectural/other/white-board-3388752a-191c-41f9-91c3-491569581484)
- 1 trashcan (https://www.cgtrader.com/free-3d-models/interior/interior-office/trash-bin-374b549a-2c61-4972-a8d0-e93dbad2b2c0)
- 6 plugs for the table (https://www.cgtrader.com/free-3d-models/electronics/other/power-plug-outlet-type-f)
- 2 plugs for the TV (https://www.cgtrader.com/free-3d-models/electronics/other/power-plug-outlet-type-f)

### b. Meetings Room

- 1 rectangle table (https://www.cgtrader.com/free-3d-models/interior/interior-office/meeting-desk)
- 10 chairs (https://www.cgtrader.com/free-3d-models/furniture/chair/chair-4b4a68cb-33a7-4155-a411-0127a9d4e1cf)
- 1 TV or video projector (https://www.cgtrader.com/free-3d-models/interior/hall/sony-led-tv-f3edc673-2c3b-4767-a062-ed2179c04f20)
- 1 whiteboard or digital whiteboard (https://www.cgtrader.com/free-3d-models/architectural/other/white-board-3388752a-191c-41f9-91c3-491569581484)
- 1 trashcan (https://www.cgtrader.com/free-3d-models/interior/interior-office/trash-bin-374b549a-2c61-4972-a8d0-e93dbad2b2c0)
- 5 plugs for the table (https://www.cgtrader.com/free-3d-models/electronics/other/power-plug-outlet-type-f)
- 2 plugs for the TV or video projector (https://www.cgtrader.com/free-3d-models/electronics/other/power-plug-outlet-type-f)

### c. Resting Rooms

- 3 circle tables (https://www.cgtrader.com/free-3d-models/interior/house-interior/table-94e1797b-d496-4a67-9f1b-e4e2ad738c45)
- 9 chairs (https://www.cgtrader.com/free-3d-models/furniture/chair/eames-dsw)
- 1 sink (https://www.cgtrader.com/free-3d-models/household/other/pia-semi-encaixe-bathroom-sink--2)
- 1 fridge (https://www.cgtrader.com/free-3d-models/interior/kitchen/supermarket-glass-door-refrigerator)
- 1 trashcan (https://www.cgtrader.com/free-3d-models/interior/interior-office/trash-bin-374b549a-2c61-4972-a8d0-e93dbad2b2c0)
- 2 microwave (https://www.cgtrader.com/free-3d-models/interior/kitchen/microwave-rigged-and-animated)
- 2 plugs for microwaves (https://www.cgtrader.com/free-3d-models/electronics/other/power-plug-outlet-type-f)
- 1 plugs for the fridge (https://www.cgtrader.com/free-3d-models/electronics/other/power-plug-outlet-type-f)


- 15 circle tables (https://www.cgtrader.com/free-3d-models/interior/house-interior/table-94e1797b-d496-4a67-9f1b-e4e2ad738c45)
- 9 chairs (https://www.cgtrader.com/free-3d-models/furniture/chair/eames-dsw)
- 90 chairs (https://www.cgtrader.com/free-3d-models/furniture/chair/eames-dsw)
- 2 sinks (https://www.cgtrader.com/free-3d-models/household/other/pia-semi-encaixe-bathroom-sink--2)
- 6 fridges (https://www.cgtrader.com/free-3d-models/interior/kitchen/supermarket-glass-door-refrigerator)
- 15 microwaves (https://www.cgtrader.com/free-3d-models/interior/kitchen/microwave-rigged-and-animated)
- 2 trashcan (https://www.cgtrader.com/free-3d-models/interior/interior-office/trash-bin-374b549a-2c61-4972-a8d0-e93dbad2b2c0)
- 2 Couchs (https://www.cgtrader.com/free-3d-models/furniture/furniture-set/patio-set-fd7e2322-9376-418c-a4c8-db823f66179d)
- 4 armchair (https://www.cgtrader.com/free-3d-models/furniture/sofa/sofa-01-36d8404f-a82d-4059-99e1-519eb96cfdce)
- 15 plugs for for microwaves (https://www.cgtrader.com/free-3d-models/electronics/other/power-plug-outlet-type-f)
- 6 plugs for the fridges (https://www.cgtrader.com/free-3d-models/electronics/other/power-plug-outlet-type-f)

### d. Robotic Room

- 2 workbenchs (https://www.cgtrader.com/free-3d-models/furniture/table/worn-d4118b93-fe82-4d9d-be5d-6c09288187bd)
- 8 chairs (https://www.cgtrader.com/free-3d-models/furniture/chair/chair-4b4a68cb-33a7-4155-a411-0127a9d4e1cf)
- 10 plugs (https://www.cgtrader.com/free-3d-models/electronics/other/power-plug-outlet-type-f)
- 1 whiteboard (https://www.cgtrader.com/free-3d-models/architectural/other/white-board-3388752a-191c-41f9-91c3-491569581484)

### e. Office Rooms

- 2 armchairs (https://www.cgtrader.com/free-3d-models/furniture/sofa/sofa-01-36d8404f-a82d-4059-99e1-519eb96cfdce)
- 1 desk chair (https://www.cgtrader.com/free-3d-models/furniture/chair/free-office-chair-low-poly-model)
- 1 Angle desk ()
- 1 trashcan (https://www.cgtrader.com/free-3d-models/interior/interior-office/trash-bin-374b549a-2c61-4972-a8d0-e93dbad2b2c0)
- 1 computer (https://www.cgtrader.com/free-3d-models/electronics/computer/gigabyte-shassis)
- 2 screens for small office and 4 screens for big office (https://www.cgtrader.com/3d-models/electronics/computer/monitor-7b3b301e-e05f-4526-8460-b65c02f0639f)
- 3 plugs for small office and 5 plugs for big office (https://www.cgtrader.com/free-3d-models/electronics/other/power-plug-outlet-type-f)

### f. Language Rooms

- 15 tables (https://www.cgtrader.com/free-3d-models/interior/interior-office/walnut-raiseable-desk)
- 16 chairs (https://www.cgtrader.com/free-3d-models/furniture/chair/chair-4b4a68cb-33a7-4155-a411-0127a9d4e1cf)
- 1 whiteboard (https://www.cgtrader.com/free-3d-models/architectural/other/white-board-3388752a-191c-41f9-91c3-491569581484)
- 1 computer (https://www.cgtrader.com/free-3d-models/electronics/computer/notebook-4892afbd-1e67-4525-8f5d-f1ca6e4f9cf9)
- 8 plugs (https://www.cgtrader.com/free-3d-models/electronics/other/power-plug-outlet-type-f)
- 1 trashcan (https://www.cgtrader.com/free-3d-models/interior/interior-office/trash-bin-374b549a-2c61-4972-a8d0-e93dbad2b2c0)
- 1 TV or video projector (https://www.cgtrader.com/free-3d-models/interior/hall/sony-led-tv-f3edc673-2c3b-4767-a062-ed2179c04f20)
- 1 desk (https://www.cgtrader.com/free-3d-models/interior/interior-office/wooden-desk-bd6cdf77-af9c-4575-a17a-ee6ffff58c03)


### g. Softskills Room

- 20 tables (https://www.cgtrader.com/free-3d-models/furniture/table/triangle-table-0b404112-25d8-4c26-807f-b7064c6227fb)
- 21 chairs (https://www.cgtrader.com/free-3d-models/furniture/chair/chair-4b4a68cb-33a7-4155-a411-0127a9d4e1cf)
- 1 desk (https://www.cgtrader.com/free-3d-models/interior/interior-office/wooden-desk-bd6cdf77-af9c-4575-a17a-ee6ffff58c03)
- 1 computer (https://www.cgtrader.com/free-3d-models/electronics/computer/notebook-4892afbd-1e67-4525-8f5d-f1ca6e4f9cf9)
- 1 whiteboard (https://www.cgtrader.com/free-3d-models/architectural/other/white-board-3388752a-191c-41f9-91c3-491569581484)
- 10 plugs (https://www.cgtrader.com/free-3d-models/electronics/other/power-plug-outlet-type-f)
- 1 trashcan (https://www.cgtrader.com/free-3d-models/interior/interior-office/trash-bin-374b549a-2c61-4972-a8d0-e93dbad2b2c0)
- 1 TV or video projector (https://www.cgtrader.com/free-3d-models/interior/hall/sony-led-tv-f3edc673-2c3b-4767-a062-ed2179c04f20)

### h. Library Room

- 16 shelves (https://www.cgtrader.com/free-3d-models/furniture/other/original-mid-century-modern-bookcases)
- 6 lazybags ()
- 2 couchs (https://www.cgtrader.com/free-3d-models/furniture/furniture-set/patio-set-fd7e2322-9376-418c-a4c8-db823f66179d)
- 4 tables (https://www.cgtrader.com/free-3d-models/furniture/table/high-quality-3d-circle-table)
- 4 chairs (https://www.cgtrader.com/free-3d-models/furniture/chair/eames-dsw)
- 2 carpets ()

### i. Reception Room

- 1 Computer (https://www.cgtrader.com/free-3d-models/electronics/computer/gigabyte-shassis)
- 1 Computer screen (https://www.cgtrader.com/3d-models/electronics/computer/monitor-7b3b301e-e05f-4526-8460-b65c02f0639f)
- 1 Chair (https://www.cgtrader.com/free-3d-models/furniture/chair/free-office-chair-low-poly-model)
- 1 Desk (https://www.cgtrader.com/free-3d-models/interior/interior-office/wooden-desk-bd6cdf77-af9c-4575-a17a-ee6ffff58c03)
- 1 Plug (https://www.cgtrader.com/free-3d-models/electronics/other/power-plug-outlet-type-f)
- 1 Trashcan (https://www.cgtrader.com/free-3d-models/interior/interior-office/trash-bin-374b549a-2c61-4972-a8d0-e93dbad2b2c0)

### j. Bathrooms

Each rooms have to contain: 
- 4 bathroom sink (https://www.cgtrader.com/free-3d-models/household/other/bathroom-sink-6b81b5bd-04ae-46b5-9102-b0cc77e1c102)
- 1 hand dryer ()
- 1 trashcan (https://www.cgtrader.com/free-3d-models/interior/interior-office/trash-bin-374b549a-2c61-4972-a8d0-e93dbad2b2c0)
- 4 mirror ()

Each toilets need to contain: 
- 1 toilet
- 1 trashcan
- 1 toilet paper dispenser 

Each disabled toilets need to contain:
- 1 toilet
- 1 metal bar on the wall
- 1 bathroom sink
- 1 trashcan
- 1 mirror

### k. Stock Rooms

- Cardboards
- 20 Shelves
- 4 Chairs
- 1 Trashcan

### l. Secured Stock Room

- 30 Shelves (https://www.cgtrader.com/free-3d-models/interior/other/school-bag-shelves)
- 1 camera (https://www.cgtrader.com/free-3d-models/electronics/video/cctv-exterior-surveillance-camera)
- Cardboards (https://www.cgtrader.com/free-3d-models/architectural/other/cardboard-boxes-pack-1-low-poly-pbr)

### m. Back Outside Deck

- 6 rectangle tables for 6 people (https://www.cgtrader.com/free-3d-models/interior/interior-office/meeting-desk)
- 8 circle tables for 4 people (https://www.cgtrader.com/free-3d-models/furniture/table/high-quality-3d-circle-table)
- 68 chairs (https://www.cgtrader.com/free-3d-models/interior/interior-office/ddlc-chair)
- 2 ashtrays (https://www.cgtrader.com/free-3d-models/interior/interior-office/used-ashtray)
- 2 trashcans (https://www.cgtrader.com/free-3d-models/interior/interior-office/trash-bin-374b549a-2c61-4972-a8d0-e93dbad2b2c0)

### n. Front Outside Deck

- 1 letter box (https://3dmdb.com/en/3d-model/boites-aux-lettres/7382250/)
- 1 doorbell (https://www.cgtrader.com/free-3d-models/architectural/decoration/doorbell-and-nametag)
- 1 scooter stand and bike stand (https://www.cgtrader.com/free-3d-models/exterior/street-exterior/old-rusted-metal-fence)
- 1 ashtray (https://www.cgtrader.com/free-3d-models/interior/interior-office/used-ashtray)
- 1 trashcan (https://www.cgtrader.com/free-3d-models/interior/interior-office/trash-bin-374b549a-2c61-4972-a8d0-e93dbad2b2c0)

### o. Amphitheater

- 1 computer (https://www.cgtrader.com/free-3d-models/electronics/computer/notebook-4892afbd-1e67-4525-8f5d-f1ca6e4f9cf9)
- 1 video projector (https://www.cgtrader.com/free-3d-models/electronics/video/beamer-low-poly)
- 1 chair (https://www.cgtrader.com/free-3d-models/furniture/chair/chair-4b4a68cb-33a7-4155-a411-0127a9d4e1cf)
- 1 reader desk 
- 1 platform
- 1 plug (https://www.cgtrader.com/free-3d-models/electronics/other/power-plug-outlet-type-f)
- 1 trash can (https://www.cgtrader.com/free-3d-models/interior/interior-office/trash-bin-374b549a-2c61-4972-a8d0-e93dbad2b2c0)

### p. Reprography

- 1 printer / scanner (https://www.cgtrader.com/free-3d-models/electronics/other/low-poly-xerox-printer)
- 1 trashcan (https://www.cgtrader.com/free-3d-models/interior/interior-office/trash-bin-374b549a-2c61-4972-a8d0-e93dbad2b2c0)
- 1 desk (https://www.cgtrader.com/free-3d-models/interior/interior-office/office-desk-c0b6c5c0-dcef-401e-a302-0f1350aa14ab)


## B. Halls
### a. Drone Zone
### b. Flight Zone
### c. Stands Zone
### d. Robotic Parkour
### e. Greener

# 5. Working Systems
## A. Permission Card
Permission cards can be used for a variety of purposes, including access to the school (during and outside of school hours), to enter classrooms and project rooms, to enter the meeting room... They can also be used to access the food and beverage dispensers and the library.

## B. Door locks

The doors will be locked to avoid any theft or material problems. They will be open only with permission cards and at certain times depending on the room (e.g.: school door, meeting room door and project room doors)

All rooms will be completely locked from 6.30pm (when the last person leaves) until 7.30am (when the first staff member arrives). 
The main entrance door will be open from 7.30am to 6.30pm. Both turnstiles will be closed at the same times as entrance door, but, you will be able to open them if you have a student/staff card which you will scan to activate the turnstile. So these cards will work between 7.30am and 6.30pm. The door next to the front turnstile will be closed at all times but will be unlockable with a key (which will be in the office closest to the reception desk to allow someone from the staff to open it during the day).

For the following rooms :
- project rooms
- office rooms
- meeting rooms
- english rooms
- stock rooms
- library
They will be unlockable between 7.30am and 6.30 pm according to the roles described in the previous sub-section.

## C. Turnstile

One turnstile is needed at the front and one at the back. The one at the front will be used for people arriving on foot, bicycle or scooter. It will be placed between the main entrance door and the "reception". The second one will be located in place of the current door behind the drone workshop and will be used by people who park their cars in the back car park. 

A door will be located on the same wall as the front turnstile. It will only be opened with a key by a member of staff. 
Between the turnstile and this door there will be a bell, which can be used by students/staff who have forgotten their cards and by guests who do not have cards. It will ring a sound in the office at the entrance so that a member of staff present in that office can open the door.

## D. Ambient sounds

beginning -> 9am : noises in corridors, resting room, outside deck and staff rooms

9am -> 10.45am : noises in all working rooms

10.45am -> 11am : noises in corridors, resting room, outside deck and staff rooms

11am -> 0.30pm : noises in all working rooms

0.30pm -> 1.30pm : noises in corridors, resting room, outside deck and staff rooms

1.30pm -> 3.15pm : noises in all working rooms

3.15pm -> 3.30pm : noises in corridors, resting room, outside deck and staff rooms

# 6. Pathfinding
## A. Project room
## B. Amphitheater
## C. Language room
## D. Robotic room
## E. Resting room
## F. Softskills room
## G. Library
## H. Bathrooms
## I. Entrance
## J. Back outside deck


# 7. Pre-made scenario

**TBD**
