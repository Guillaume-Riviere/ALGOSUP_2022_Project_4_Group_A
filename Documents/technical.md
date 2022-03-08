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
### b. Meetings Room
### c. Resting Rooms
### d. Robotic Room
### e. Office Rooms
### f. Language Rooms
### g. Softskills Room
### h. Library Room
### i. Reception Room
### j. Bathrooms
### k. Stock Rooms
### l. Secured Stock Room
### m. Back Outside Deck
### n. Front Outside Deck
### o. Amphitheater
### p. Reprography

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

## C. Turnstile
## D. Ambient sounds

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
