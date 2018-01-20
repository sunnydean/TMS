# Summary

In the world of today video games have become the main source of entertainment. Namely that is the goal of “The Music Scrolls”, to be a mainly entertaining and partially educating musical game. The game achieves this by giving the opportunity of playing guitar in real time while experiencing an interactive story. The target audience is every music lover of every age group with the appropriate equipment. In contrast to other musical games in this one you can play music in an unconstrained environment that is free for improvising.

---

# Introduction

Today, most people use video games as their major form of entertainment. As time progresses, they become more and more accessible, allowing developers to express their imagination even more. This project is an original concept that has not yet been developed. There is a great lack of music games on the market as a whole. Unlike other music games, in this one you play real guitar in an non-restricting environment. Instead of using the typical age old combination, mouse and keyboard, the game combines mouse and guitar into a challenging new product.

---

# Exposition

 Banknotes By Notes is a 3D entertainment game that features:
 
• Action - fighting with enemies

• Role-playing game - because you play from the role of the hero in a fictional plot.

• Fantasy - because of all the fantastic elements in the game

• Adventure - because the player is a protagonist in an interactive story in an open world

• Musical - because of the musical elements and the playing of an instrument in real-time in-game


---

# Plot

In the game, the player is in an alternate dark-age universe and takes on the role of a musician(Stoyan) making his living on the streets. His friend Strash is kidnapped by the evil villain Bad. This causes the hero to suffer and turn to the god of music that gives Stoyan a magical guitar that gets stronger with each good thing he does.

---

# milestones in project development

**Major milestones in the development of the project are divided into four main stages:**

**Preparation and selection of the most appropriate equipment**

Choosing the right way to connect the instrument to your computer so as to minimize latency and increase the sound quality.

**Writing the code for mechanics and information processing**

Through the built-in platform of Unity, MonoDevelop. Creating a program code to process the sound data from playing guitar into usable data. Creating controls for the player. Creating artificial intelligence, physics for the game, creating enemies.

**Creating objects and models**

Through Blender and Adobe Photoshop CS6. Creating the hero and his animations. Creating different textures and game elements.

**Assembling all parts in one project**

Through Unity. Collect and combine all elements of textures and code into scenes. Arrange these scenes in meaningful order and compile the project

---

# Main Difficulties

The main difficulty was achieving the clearest input of guitar sound data while selecting the right and optimal solutions to allow for the maintenance of different operating systems and hardware platforms.
 Another big problem was preparing and selecting the appropriate equipment. Because of our limited target group, I had to find the most accessible equipment that every guitarist has or could easily get.
 

---
# Connecting The Guitar and Processing the Music!

This is the more interesting and unique part of the game. It gives the player the opportunity to play real-time guitar in real time. These were the hardware problems of the project:

---

# Connecting The Guitar


• Finding an cheap way to connect guitar and PC

• Connecting the guitar to the computer while also keeping the sound clean

After investigating and testing various ways, I found that the most affordable way to connect is via the microphone jack. By doing it like so, it doesn't further limit the target group by making it accessible without expensive sound systems, sound software, and so on. 
 You only need a 6.35mm to 3.5mm Jack to a Jack cable that connects to the computer's sound card through the mic-in port, and after that the sound is processed
 
 ![Screenshot](https://farm5.staticflickr.com/4658/28016033059_9ce9bbfe8e.jpg)

If the player already has a specialized sound card, it is no problem to connect the guitar directly to the computer as shown in the above image.
 But doing it this way the sound is usually unclear and distorted due to the inability of a non-specialized sound card to process the sound data.

In order to solve this problem, I decided to use already processed sound using an amplifier as a mediator. 
 By doing it like that we do not need to buy specialized devices (given that the player has an amplifier already). The player needs only:

• One 6.35mm to 3.5mm Jack to Jack

• One 6.35mm to 6.5mm Jack to Jack

• an amplifier for his guitar 

![Screenshot](https://farm5.staticflickr.com/4658/28016032359_1519eedc1c.jpg)

---

# Processing the Music! 

To create a note recognition algorithm, I've used the following method:

Already knowing that there is a class in Unity that uses Mic-in data I used that directly to get the inputs and then did some smoothing over.

And after getting the microphone data, we can analyze it. 
To do this, I have utilized the FFT (Fast Fourier Transform) method to extract the frequency of a given signal. 
What is an FFT algorithm (general idea):

You get an array of time waveform samples and process them to get an array of spectrum samples.

![Screenshot](https://farm5.staticflickr.com/4610/28016032449_9624438e79.jpg)


>
Fast Fourier Transform (FFT) algorithm computes a discrete Fourier Transform (DFT) of a sequence, or its reverse. Fourier analysis converts the signal from its original domain (often time or space) to representation in the frequency domain and vice versa. An FFT quickly calculates such transformations from the factorizing matrix DFT into a product of scarce (predominantly zero) factors. As a result, it succeeds in reducing the complexity of calculating a DFT of (O x (N ^ 2) that occurs if one simply applies the definition of DFT, O x (px N x log p), where p is the size data.
>

---

# Realization

For the creation of this project I have used: 
- Unity (C# and JavaScript)
- Blender
- Adobe Photoshop
- A Strat and some cheap amp

---

# System Requirements

OS - Windows (XP / Vista / 7)

DirectX 9+

CPU: Pentium 4+

RAM: 1GB +

Screen with resolution greater than 1024 x 768 pixels

---

# Demo description:


1. WARNING: Have your headphones on because of feedback loops(if you do not have a guitar cable connected)

2. When you enter the game, go to the white ball, and follow the instructions

3. Then light beams will appear on the flying lump of land, click on them to teleport to them

4. Click on the circling dragon to see an example of how the player will be fighting 

5. You can continue down the islands and attack the small mushrooms to see how mob battles will take place

---
# Controls

• Hold the left mouse button (M0) to rotate the camera

• Hold the right mouse button (M1) to rotate the character

• Hold M0 & M1 to move the hero in the direction of the camera

• Press M0 to select a target

• When attacking, the displayed tab's notes are the ones you need to play after a target has been selected

• Esc to pause

• Jump Space

---

# Game Screenshots

Unity Editing Regions

![Screenshot](https://farm5.staticflickr.com/4766/28016032919_2c57ec7e52.jpg)



Getting Attacked by Slimes
![Screenshot](https://farm5.staticflickr.com/4744/28016032839_d8ee24b86b.jpg)



Slime Model Close-up
![Screenshot](https://farm5.staticflickr.com/4755/28016032709_bca5c52cc9.jpg)



Demo version start
![Screenshot](https://farm5.staticflickr.com/4768/39765528472_e759705124.jpg)




Me Presenting the game :)

![Screenshot](https://farm5.staticflickr.com/4662/39797351231_e57eb34a95.jpg)


---
# References

[http://unity3d.com/](http://unity3d.com/)

[https://www.blender.org/](https://www.blender.org/)

[https://www.assetstore.unity3d.com/en/](https://www.assetstore.unity3d.com/en/)

[http://www.blendswap.com/](http://www.blendswap.com/)

---

# Conclusion

The result is a highly developed foundation on which a multitude of ideas can be built upon. It is an original concept that has not yet been developed. The main objective of the game is to create a fun interactive guitar game. With an attractive idea and concept, the product will be able to find its way into the market and will probably find easy sponsorship.

---
