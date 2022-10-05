Lukas Bang Stoltz-Andersen	
# Test_Handin_2

## **1 Reflections**

### 1. **Computer mouse**

Type of testing I would perform on computer mouse, to make sure its of high quality

- Test if right-/leftclick functions properly
- Check if scrollwheeel functions properly
- Test if the mouse works on certain surfaces
- Check if the movementspeed of the mouse is consistent
- Check the range of the mouse if wireless + battery

### **1.2 Catastrophic failure**

A catastrophe bound to happen – mitID

At the moment, mitID only requires a UserID to login. This userID is to be kept a secret, which is quite unusual for a username. If a user tries to login many times, the will get timeouted, and eventually banned by the service. Many people have simply used their first+lastname combined as their userID (as had I). I then found out, that its case insensitive, so making some uppercase and some lowercase letters in your UserID has no effect. This is bound to lock a lot of people, user their firstname + lastname as a UserID out of the application soon. It will be easy for hackers to simply find names of Danish citizens, and spam the login page of MitID, and ban all the people. 

This could be easily avoided by testing the software more thoroughly (DON’T IGNORE UPPERCASE/LOWERCASE??? COMEON), and maybe implementing an actual password. Clearly they haven’t used BDD – cause if they had, the current implementation would never excist, since its quite stupid to say the least…..

## **2 Two Katas**

### **2.1 String Utility**

To simplify string functions only work with letters a-h

**Reverse string**

Given a string of x letters, I want to return the same string, with all characters reversed

**Capitalize string**

Given a string of x letters, I want to return the same string, with all characters capitalized

**Lowercase string**

Given a string of x letters, I want to return the same string, with all characters lowercased

### **2.2 Bowling game**

## **3 Investigation of tools**

### **3.1 Junit5**

**@Tag**

You can give a test a tag, and then create testsuites which only executes test with given tags.

**@Disabled**

Don’t run the test

**@RepeatedTest**

**@BeforeEach, @AfterEach**

Runs before/after each test. Could be dropping a database and so on.

**@BeforeAll, @AfterAll**

Same as above, but only before/after all tests have run

**@DisplayName**

Creates a displayname for the test

**@Nested**

**assumeFale**

assumes the test will fail (if it does = success)

**assumeTrue**

Assuemes that the test will succeed.

### **3.2 Mocking Frameworks**

**Chosen**: Moq and Nsubstitute

**Similarities**: 

The functionality in both frameworks is borderline the same. They are able to solve the same problems

**Differences**:

The two frameworks differ a lot in their syntax. An example below when mocking a property, its a lot more simple to understand the mocking in Nsubstitute

![alt text](\picture\pic1.PNG "Title")

For throwing exceptions it’s the other way around. Here the Moq frameworks handles it a bit more elegantly:

![alt text](\picture\pic1.PNG "Title")

**Preferred**: 

I prefer Nsubstitute, as I like the simplicity of the syntax a lot more than Moq. Only in a few areas like Exceptions I prefer Moq. But for mocking methods, properties and so on, the simplicity of Nsubstitute wins for me….


