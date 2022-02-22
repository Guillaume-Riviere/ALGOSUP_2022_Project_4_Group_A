---
Table of Contents

- [1. Introduction](#1-introduction)
- [2. What's VR ? Why VR ?](#2-whats-vr--why-vr-)
- [3. General Needs](#3-general-needs)
- [4. Environments](#4-environments)
  - [A. Rooms](#a-rooms)
    - [a. Project Rooms](#a-project-rooms)
    - [b. Meetings Room](#b-meetings-room)
    - [c. Resting Rooms](#c-resting-rooms)
    - [d. Robotic Room](#d-robotic-room)
    - [e. Office Rooms](#e-office-rooms)
    - [f. English Rooms](#f-english-rooms)
    - [g. Softskills Room](#g-softskills-room)
    - [h. Library Room](#h-library-room)
    - [i. Reception Room](#i-reception-room)
    - [j. Bathrooms](#j-bathrooms)
    - [k. Stock Rooms](#k-stock-rooms)
    - [l. Back Outside Deck](#l-back-outside-deck)
    - [m. Front Outside Deck](#m-front-outside-deck)
    - [n. Amphitheater](#n-amphitheater)
  - [B. Halls](#b-halls)
    - [a. Drone Zone](#a-drone-zone)
      - [1. Flight Zone](#1-flight-zone)
      - [2. Stands Zone](#2-stands-zone)
    - [b. Robotic Parcour](#b-robotic-parcour)
    - [c. Greenery](#c-greenery)
    - [d. Entrance](#d-entrance)
  - [C. Sounds](#c-sounds)
    - [a. Doors](#a-doors)
    - [b. Ambient Sounds](#b-ambient-sounds)
      - [1. Resting Rooms](#1-resting-rooms)
      - [2. Occupied Rooms](#2-occupied-rooms)
      - [3. Halls](#3-halls)
      - [4. Drone Flights](#4-drone-flights)
- [5. Working Systems](#5-working-systems)
  - [A. Opening Hours](#a-opening-hours)
  - [B. Booking Rooms](#b-booking-rooms)
    - [a. Entrance Screen](#a-entrance-screen)
    - [b. Booking Process](#b-booking-process)
  - [C. Permissions Card](#c-permissions-card)
    - [a. Physical Visitor](#a-physical-visitor)
    - [b. Virtual Visitor](#b-virtual-visitor)
    - [c. Student](#c-student)
    - [d. Staff](#d-staff)
  - [D. Doors Lock](#d-doors-lock)
    - [a. Physical Visitor](#a-physical-visitor-1)
    - [b. Virtual Visitor](#b-virtual-visitor-1)
    - [c. Student](#c-student-1)
    - [d. Staff](#d-staff-1)
    - [e. Stanger](#e-stanger)
  - [E. Privacy](#e-privacy)
  - [F. VR Miscellaneous](#f-vr-miscellaneous)
    - [a. Time change](#a-time-change)
    - [b. Peoples in School](#b-peoples-in-school)
    - [c. Teleportation to short distance](#c-teleportation-to-short-distance)
    - [d. Welcome NPC](#d-welcome-npc)
- [6. User cases](#6-user-cases)
  - [A. Physical Visitor](#a-physical-visitor-2)
    - [a. Entering empty room](#a-entering-empty-room)
    - [b. Entering occupied room](#b-entering-occupied-room)
    - [c. Entering staff reserved room](#c-entering-staff-reserved-room)
  - [B. Virtual Visitor](#b-virtual-visitor-2)
    - [a. Entering empty room](#a-entering-empty-room-1)
    - [b. Entering occupied room](#b-entering-occupied-room-1)
    - [c. Entering Staff reserved room](#c-entering-staff-reserved-room-1)
  - [C. Student](#c-student-2)
    - [a. Entering empty room](#a-entering-empty-room-2)
    - [b. Entering occupied room](#b-entering-occupied-room-2)
    - [c. Entering Staff reserved room](#c-entering-staff-reserved-room-2)
    - [d. Booking a free room](#d-booking-a-free-room)
    - [e. Booking a reserved room](#e-booking-a-reserved-room)
    - [f. Booking a free room with privacy](#f-booking-a-free-room-with-privacy)
    - [g. Booking a meeting room](#g-booking-a-meeting-room)
  - [D. Staff](#d-staff-2)
    - [a. Entering empty room](#a-entering-empty-room-3)
    - [b. Entering occupied room](#b-entering-occupied-room-3)
    - [c. Entering Staff reserved room](#c-entering-staff-reserved-room-3)
    - [d. Booking a meeting room](#d-booking-a-meeting-room)
  

---


# 1. Introduction

The goal of the project is to provide a way to visit the school as if we were in.
It will be visitable using **Virtual Reality** headset.

It should be able to anticipate issues that could append in the school and also a way to visit the school without being physically in it.

All logic systems should also be applied to the virtual environment. By logic systems, we mainly means doors locked to unauthorized peoples.

Some scenarios should be possible to simulate in order to see what append in the school

It's also a realistic simulation, it's not a video game.
Physics have to be applied to objets, rooms, user.
By physics we means no flight across walls, no permissions bypass not planned.

# 2. What's VR ? Why VR ?

**VR** stands for **Virtual Reality**
VR is a simulated world that can be similar to or completely different from the real world. In that case, closest to reality, better it will be.
VR is simulated using a Headset that the user have to wear to visit the simulation

Since we want a realistic simulation, VR is the closest to the reality.
It allows a user to simulate the school as if he was inside.
VR could have been avoided but the immersion wouldn't have been as intense.

# 3. General Needs

We need a realistic representation of the school, as realistic as possible. 
That include: 
- Working doors
- Door lock
- Ambient sounds
- Furnitures
- Differents user cases 

It need to be visitable using VR Headset, from any headset and anywhere.


# 4. Environments

This section will detail all furnitures needed in the school.

## A. Rooms
### a. Project Rooms

Each project rooms are 20m² and are designed to fit 6 peoples.

Each rooms have to contain: 
- 1 rectangle table
- 6 chairs
- 1 TV or big screen
- 1 whiteboard or digital whiteboard
- 1 trashcan
- 6 plugs for the table
- 2 plugs for the TV

### b. Meetings Room

The meeting room is 25m² and is designed to fit 8 to 10 peoples.

The meetings romms have to contain:
- 1 rectangle table
- 10 chairs
- 1 TV or video projector
- 1 whiteboard or digital whiteboard
- 1 trashcan
- 5 plugs for the table
- 2 plugs for the TV or video projector


### c. Resting Rooms

The Staff resting room is 33.6m² and is designed to fit 9 peoples.

The staff resting room have to contain:
- 3 circle tables
- 9 chairs
- 1 sink
- 1 fridge
- 1 trashcan
- 1 plugs for the fridge


The Student resting room is 150.59m² and is designed to fit 90 peoples.

The student resting room have to contain:
- 15 circle tables
- 90 chairs
- 2 sinks
- 6 fridges
- 15 microwaves
- 2 trashcan
- 2 Couchs
- 4 armchair
- 6 plugs for the fridges

### d. Robotic Room

The Robotic room is 28.47m² and is designed to fit 8 peoples.

The robotic room have to contain:
- 2 workbenchs
- 8 chairs
- 10 plugs
- 1 whiteboard

### e. Office Rooms

Office rooms are 3x 20m² and 1x 29.2m² and are designed to fit 3 to 5 peoples.

Office rooms have to contain:
- 2 armchairs
- 1 desk chair
- 1 Angle desk
- 1 trashcan
- 1 computer
- 2 screens for small office and 4 screens for big office
- 3 plugs for small office and 5 plugs for big office

### f. English Rooms

English rooms are 40.50m² and are designed to fit 15 peoples.

English rooms have to contain:
- 15 tables
- 16 chairs
- 1 whiteboard
- 8 plugs
- 1 trashcan
- 1 TV or video projecteur
- 1 desk

### g. Softskills Room
### h. Library Room
### i. Reception Room

Reception room is 12.37m² and is designed to fit 1 person.

Reception room have to contain:
-1 Computer
-1 Chair
-1 Desk
-1 Plug
-1 Trashcan
### j. Bathrooms
### k. Stock Rooms
### l. Back Outside Deck
### m. Front Outside Deck
### n. Amphitheater

## B. Halls
### a. Drone Zone

Drone Zone is 78.54m² and is designed to fit Drones.

Drone Zone have to contain:

-1 Drone
-1 Character who controls the drone
#### 1. Flight Zone
#### 2. Stands Zone
### b. Robotic Parcour
### c. Greenery
### d. Entrance

## C. Sounds
### a. Doors
### b. Ambient Sounds
#### 1. Resting Rooms
#### 2. Occupied Rooms
#### 3. Halls
#### 4. Drone Flights

# 5. Working Systems
## A. Opening Hours

## B. Booking Rooms
### a. Entrance Screen
### b. Booking Process

## C. Permissions Card
### a. Physical Visitor
### b. Virtual Visitor
### c. Student
### d. Staff

## D. Doors Lock
### a. Physical Visitor
### b. Virtual Visitor
### c. Student
### d. Staff
### e. Stanger

## E. Privacy

## F. VR Miscellaneous
### a. Time change
### b. Peoples in School
### c. Teleportation to short distance
### d. Welcome NPC 

# 6. User cases
## A. Physical Visitor
### a. Entering empty room
### b. Entering occupied room
### c. Entering staff reserved room

## B. Virtual Visitor
### a. Entering empty room
### b. Entering occupied room
### c. Entering Staff reserved room

## C. Student
### a. Entering empty room
### b. Entering occupied room
### c. Entering Staff reserved room
### d. Booking a free room
### e. Booking a reserved room
### f. Booking a free room with privacy
### g. Booking a meeting room

## D. Staff
### a. Entering empty room
### b. Entering occupied room
### c. Entering Staff reserved room
### d. Booking a meeting room