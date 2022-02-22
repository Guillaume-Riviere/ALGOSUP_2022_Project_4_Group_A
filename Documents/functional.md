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
    - [l. Secured Stock Room](#l-secured-stock-room)
    - [m. Back Outside Deck](#m-back-outside-deck)
    - [n. Front Outside Deck](#n-front-outside-deck)
    - [o. Amphitheater](#o-amphitheater)
  - [B. Halls](#b-halls)
    - [a. Drone Zone](#a-drone-zone)
      - [1. Flight Zone](#1-flight-zone)
      - [2. Stands Zone](#2-stands-zone)
    - [b. Robotic Parkour](#b-robotic-parkour)
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
  - [A. Opening Hours To Public](#a-opening-hours-to-public)
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
    - [e. Stranger](#e-stranger)
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
- 2 microwave
- 2 plugs for microwaves
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
- 15 plugs for for microwaves
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
- 1 computer
- 8 plugs
- 1 trashcan
- 1 TV or video projector
- 1 desk

### g. Softskills Room

Softskills room is 70.20m² and is designed to fit 20 peoples.

Softskills room have to contain:
- 20 tables
- 21 chairs
- 1 desk
- 1 computer
- 1 whiteboard
- 10 plugs
- 1 trashcan
- 1 TV or video projector

### h. Library Room

Library is 45,79m² and is designed to fit 16 peoples.

Library have to contain: 
- 16 shelves
- 6 lazybags
- 2 couchs
- 4 tables
- 4 chairs
- 2 carpets

### i. Reception Room

Reception room is 12.37m² and is designed to fit 1 person.

Reception room have to contain:
- 1 Computer
- 1 Chair
- 1 Desk
- 1 Plug
- 1 Trashcan

### j. Bathrooms

Bathrooms room are 29.65m² each. These are designed to fit 7 peoples each. Each toilet is separate by doors and walls. There is 3 normal toilets and 1 disabled toilet in each bathroom.

Each rooms have to contain: 
- 4 bathroom sink
- 1 hand dryer
- 1 trashcan
- 4 mirror

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

Stock rooms are 28,78m² and 21,46m² and is designed to fit 2 people and 1 person respectively.

Stock rooms have to contain:
- Cardboards
- 20 Shelves
- 4 Chairs
- 1 Trashcan

### l. Secured Stock Room

Secured Stock Room is 29,98m² and is designed to fit 3 people.

Secured Stock Room have to contain:
- 30 Shelves
- 1 camera
- Cardboards

### m. Back Outside Deck

The back outside deck is 183.14m². It's designed to fix 100 people.

The back outside deck have to contain:
- 6 circle tables for 6 people
- 8 circle tables for 4 people
- 68 chairs
- 2 ashtrays
- 2 trashcans

### n. Front Outside Deck

Front outside deck is before the Entrance. It is in the outside of the school.

The front outside deck have to contain:
- 1 letter box
- 1 doorbell
- 1 bike stand
- 1 scooter stand
- 1 ashtray
- 1 trashcan

### o. Amphitheater

Amphitheater room is 133.90m² and is designed to fit 80 people.

Amphitheater have to contain :
- 1 computer
- 1 video projector
- 1 screen
- 1 chair
- 1 reader desk
- 1 platform
- 1 plug for the computer
- 1 plug for the video projector 
- 1 trash can

## B. Halls
### a. Drone Zone
#### 1. Flight Zone

Drone Zone is 78.54m² and is designed to fit Drones.

Drone Zone have to contain:
- 1 Drone

#### 2. Stands Zone

Stands Zone is 33.72m² and is designed to 12-15 people.

Stands Zone have to contain:
- 1 Bleacher

### b. Robotic Parkour

The robotic parkour is in the principal corridor.

The robotic parkour have to contain:
- 6 obstacles

### c. Greenery

We'll find Greenery everywhere in the school , on the roof of the rooms.
Also in each room to fill them and fell closer to the nature.

### d. Entrance

The entrance have to contain:
- 1 screen
- 1 plug for the screen 

## C. Sounds
### a. Doors

The doors need to do a sound when you open it with your card, when you close it and when you can't open it.

### b. Ambient Sounds
#### 1. Resting Rooms

The resting rooms need to do the noises of 90 people who are eating and talking. You also need noises of microwaves and televisions.

#### 2. Occupied Rooms

The occupied rooms need to have noises of working people.

#### 3. Halls

In the halls, you can hear students talking and walking, the drone flying and robots driving.

#### 4. Drone Flights

# 5. Working Systems
## A. Opening Hours To Public

The school is opened to public between **9AM - 12AM** and **1PM - 5PM**.

## B. Booking Rooms

### a. Entrance Screen

A big tactile screen will be require after the entrance on the right.
The purpose of it is to be able to book a rooms and see which romm is occupied during the day.
It could also in the futur, display a slider of schedule when idle.

### b. Booking Process

You first will have to scan your card to identify yourself.
Then you will have to set the time range you need a room.
and last you will see all available rooms for you in green, you will also see unavailable room in red.

You will have to specify a reason of booking, and if you need the privacy option (detailed below)

## C. Permissions Card

Everyone must have a permission card to interact in the school (open room, booking rooms...).

### a. Physical Visitor

| Permission  | Allow | Deny|
| :---------- |:-----:|:---:|
| Open empty room  | X |  |
| Open reserved room |  | X |
| Book a room |  | X |
| Open empty meeting room | X |  |
| Open reserved meeting room |  | X |
| Open office |  | X |
| Enter school outisde of opening hours |  | X |
| Enter school in opening hours | X |  |
| Open stock rooms |  | X |

### b. Virtual Visitor

| Permission  | Allow | Deny|
| :---------- |:-----:|:---:|
| Open empty room  | X |  |
| Open reserved room | X |  |
| Book a room | X |  |
| Open empty meeting room | X |  |
| Open reserved meeting room | X |  |
| Open office | X |  |
| Enter school outisde of opening hours | X |  |
| Enter school in opening hours | X |  |
| Open stock rooms | X |  |

### c. Student

| Permission  | Allow | Deny|
| :---------- |:-----:|:---:|
| Open empty room  | X |  |
| Open reserved room |  |X |
| Book a room | X |  |
| Open empty meeting room |  | X |
| Open reserved meeting room |  | X |
| Open office |  | X |
| Enter school outisde of opening hours |  | X |
| Enter school in opening hours | X |  |
| Open stock rooms |  | X |

### d. Staff

| Permission  | Allow | Deny|
| :---------- |:-----:|:---:|
| Open empty room  | X |  |
| Open reserved room | X |  |
| Book a room | X |  |
| Open empty meeting room | X |  |
| Open reserved meeting room | X |  |
| Open office | X |  |
| Enter school outisde of opening hours | X |  |
| Enter school in opening hours | X |  |
| Open stock rooms | X |  |

## D. Doors Lock

All doors will require a permission access card in order to open it.
Since the hall will be accessible by stranger, by Cpam's people and other people, it need to be securised.
All Algosup users or staff will have different permissions in order to achieve that security.

### a. Physical Visitor

| Permission  | Allow | Deny|
| :---------- |:-----:|:---:|
| Open project room | X |  |
| Open office room |  | X |
| Open meeting room |  | X |
| Open english room | X |  |
| Open stock room |  | X |
| Open library | X |  |

### b. Virtual Visitor

| Permission  | Allow | Deny|
| :---------- |:-----:|:---:|
| Open project room | X |  |
| Open office room | X |  |
| Open meeting room | X |  |
| Open english room | X |  |
| Open stock room | X |  |
| Open library | X |  |

### c. Student

| Permission  | Allow | Deny|
| :---------- |:-----:|:---:|
| Open project room | X |  |
| Open office room |  | X |
| Open meeting room |  | X |
| Open english room | X |  |
| Open stock room |  | X |
| Open library | X |  |

### d. Staff

| Permission  | Allow | Deny|
| :---------- |:-----:|:---:|
| Open project room | X |  |
| Open office room | X |  |
| Open meeting room | X |  |
| Open english room | X |  |
| Open stock room | X |  |
| Open library | X |  |

### e. Stranger

| Permission  | Allow | Deny|
| :---------- |:-----:|:---:|
| Open project room |  | X |
| Open office room |  | X |
| Open meeting room |  | X |
| Open english room |  | X |
| Open stock room |  | X |
| Open library |  | X |

## E. Privacy

In our work, sometimes we have to work on project that are secret and are subject to privacy rules. 
So we though about a way to be able a have privacy while coridor are transparent glass. 

So when you will book a room, you will be able to ask for privacy.
It have to be validate by a Staff members of the school. 

If it have been validated by a staff member, the glass of your room will be obfuscated for the time you reserved it.

## F. VR Miscellaneous
### a. Time change

We'll be able to change the time with a device , This device will be 
usefull to show to the customer the permission with the time when the door will be locked automatically.

### b. Peoples in School
### c. Teleportation to short distance

We'll be able to teleport the user to a place , to avoid the walk time and lost time during a presentation
and if the customer want to see a specific room or place.

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