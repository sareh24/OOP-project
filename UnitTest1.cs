using Microsoft.VisualStudio.TestTools.UnitTesting;
using assign2;
using System;
using System.Collections.Generic;
using System.IO;
using TextFile;

namespace testing;

[TestClass]
public class UnitTest1
{

    [TestMethod]
    public void EmptyFile()
    {
        TextFileReader reader = new TextFileReader("empty.txt");
        Assert.ThrowsException<Exception>(() =>
        {

           throw new Exception("the file is empty");
            
        });
    }
    [TestMethod]
    public void testName()
    {
        Dog dog = new Dog("Lassie", 40);
        string name = dog.Name();
        Assert.AreEqual("Lassie", name);
        Fish f = new Fish("nemo", 10);
        string name2 = f.Name();
        Assert.AreEqual("nemo", name2);

    }
    [TestMethod]
    public void testExhib()
    {
        Dog dog = new Dog("Lassie", 40);
        int exhibit = dog.Exhib();
        Assert.AreEqual(40, exhibit);
        Fish f = new Fish("nemo", 10);
        int e2 = f.Exhib();
        Assert.AreEqual(10, e2);

    }
    [TestMethod]
    public void testModi()
    {
        Bird bird= new Bird("Sa", 32);
        bird.modify(10);
        Assert.AreEqual(42, bird.Exhib());
        Fish fish= new Fish("E", 190);
        fish.modify(-20);
        Assert.AreEqual(170, fish.Exhib());
    }
    [TestMethod]
    public void testAlive()
    {
        Dog d = new Dog("Buddy", 32);
        Assert.IsTrue(d.alive());
        Bird b = new Bird("C", 0);
        Assert.IsFalse(b.alive());
        Dog d2 = new Dog("e", -1);
        Assert.IsFalse(d2.alive());
    }
    [TestMethod]
    public void testcreate()
    {

        TextFileReader reader = new("1.txt");
        List<Animals> animalsList = Animals.create(ref reader);


        Assert.AreEqual(3, animalsList.Count);
        Assert.AreEqual("Nemo", animalsList[0].Name());
        Assert.AreEqual(50, animalsList[0].Exhib());
        Assert.AreEqual("Hedwig", animalsList[1].Name());
        Assert.AreEqual(20, animalsList[2].Exhib()); 

    }
    [TestMethod]
    public void testcreate2()
    {
   
        TextFileReader reader = new ("input1.txt");
        List<char> moodsList = Animals.create2(ref reader);

        
        Assert.AreEqual(5, moodsList.Count);
        Assert.AreEqual('g', moodsList[0]);
        Assert.AreEqual('g', moodsList[1]);
        Assert.AreEqual('o', moodsList[2]);
        Assert.AreEqual('b', moodsList[3]);
        Assert.AreEqual('b', moodsList[4]);

    }
    [TestMethod]
    public void testchangeGood()
    {

        Dog dog = new Dog("Lassie", 30);
        Fish fish = new Fish("Nemo", 50);
        Bird bird = new Bird("Hedwig", 70);
        Cathy cathy = Good.Instance();
        cathy.change(dog);
        cathy.change(fish);
        cathy.change(bird);
        Assert.AreEqual(33, dog.Exhib()); 
        Assert.AreEqual(51, fish.Exhib());  
        Assert.AreEqual(72, bird.Exhib());

    }
    [TestMethod]
    public void testchangeOrdinary()
    {

        Dog dog = new Dog("Lassie", 10);
        Fish fish = new Fish("Nemo", 30);
        Bird bird = new Bird("Hedwig", 101);
        Cathy cathy = Ordinary.Instance();
        cathy.change(dog);
        cathy.change(fish);
        cathy.change(bird);
        Assert.AreEqual(10, dog.Exhib());
        Assert.AreEqual(27, fish.Exhib());
        Assert.AreEqual(100, bird.Exhib());

    }
    [TestMethod]
    public void testchangeBad()
    {

        Dog dog = new Dog("Lassie", 80);
        Fish fish = new Fish("Nemo", 60);
        Bird bird = new Bird("Hedwig", 20);
        Cathy cathy = Bad.Instance();
        cathy.change(dog);
        cathy.change(fish);
        cathy.change(bird);
        Assert.AreEqual(70, dog.Exhib());
        Assert.AreEqual(55, fish.Exhib());
        Assert.AreEqual(17, bird.Exhib());

    }
    public void testtheirExhib()
    {

        Dog dog = new Dog("Lassie", 80);
        Cathy cathy = Bad.Instance();
        dog.theirExhib(cathy);
        Assert.AreEqual(70, dog.Exhib());
        Fish fish = new Fish("Nemo", 2);
        cathy = Good.Instance();
        fish.theirExhib(cathy);
        Assert.AreEqual(3, fish.Exhib());
        cathy = Bad.Instance();
        fish.theirExhib(cathy);
        fish.theirExhib(cathy);
        Assert.AreEqual(0, fish.Exhib());
        Assert.IsFalse(fish.alive());
    }
    [TestMethod]
    public void testIncrease()
    {

        var cathy = Good.Instance();
        var animalList = new List<Animals> {
        new Dog("Buddy", 3),
        new Fish("Nemo", 2),
        new Bird("Hedwig", 3)

    };
        foreach (Animals animal in animalList)
        {
            animal.theirExhib(cathy);
        }
        Assert.IsFalse(cathy.HerMood() > 0);

    }
    [TestMethod]

    public void TestMethod1()
    {
    }
}
