using System;
using System.Collections.Generic;

public class ScriptureGenerator
{
    private List<Scripture> _scriptures = new List<Scripture>();
    private void AddScripture(Scripture scripture)
    {
        _scriptures.Add(scripture);
    } 

    private Scripture GetRandomIndex()
    {   
        Random random = new Random();
        int index = random.Next(_scriptures.Count);

        return _scriptures[index];
    }

    public Scripture GetRandomScripture()
    {
        ScriptureGenerator theScripture = new ScriptureGenerator();
        Reference reference1 = new Reference("Moroni", 7, 15, 16);
        Scripture scripture1 = new Scripture(reference1, "For behold, my brethren, it is given unto you to judge, that ye may know good from evil; and the way to judge is as plain, that ye may know with a perfect knowledge, as the daylight is from the dark night.\nFor behold, the Spirit of Christ is given to every man, that he may know good from evil; wherefore, I show unto you the way to judge; for every thing which inviteth to do good, and to persuade to believe in Christ, is sent forth by the power and gift of Christ; wherefore ye may know with a perfect knowledge it is of God.");
        Reference reference2 = new Reference("1 Nephi", 3, 7);
        Scripture scripture2 = new Scripture(reference2, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        Reference reference3 = new Reference("Mosiah", 3, 7);
        Scripture scripture3 = new Scripture(reference3, "And he shall cast out devils, or the evil spirits which dwell in the hearts of the children of men.");
        Reference reference4 = new Reference("Alma", 7, 11, 13);
        Scripture scripture4 = new Scripture(reference4, "And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people.\nAnd he will take upon him death, that he may loose the bands of death which bind his people; and he will take upon him their infirmities, that his bowels may be filled with mercy, according to the flesh, that he may know according to the flesh how to succor his people according to their infirmities.\nNow the Spirit knoweth all things; nevertheless the Son of God suffereth according to the flesh that he might take upon him the sins of his people, that he might blot out their transgressions according to the power of his deliverance; and now behold, this is the testimony which is in me.");
        Reference reference5 = new Reference("2 Nephi", 28, 31);
        Scripture scripture5 = new Scripture(reference5, "Cursed is he that putteth his trust in man, or maketh flesh his arm, or shall hearken unto the precepts of men, save their precepts shall be given by the power of the Holy Ghost.");
        Reference reference6 = new Reference("2 Nephi", 32, 6);
        Scripture scripture6 = new Scripture(reference6, "Behold, this is the doctrine of Christ, and there will be no more doctrine given until after he shall manifest himself unto you in the flesh. And when he shall manifest himself unto you in the flesh, the things which he shall say unto you shall ye observe to do.");
        Reference reference7 = new Reference("Jacob", 5,31);
        Scripture scripture7 = new Scripture(reference7, "And the Lord of the vineyard said unto them: Go to, and labor in the vineyard, with your might. For behold, this is the last time that I shall nourish my vineyard; for the end is nigh at hand, and the season speedily cometh; and if ye labor with your might with me ye shall have joy in the fruit which I shall lay up unto myself against the time which will soon come.");
        Reference reference8 = new Reference("Alma", 32, 26);
        Scripture scripture8 = new Scripture(reference8, "Now, as I said concerning faith—that it was not a perfect knowledge—even so it is with my words. Ye cannot know of their surety at first, unto perfection, any more than faith is a perfect knowledge.");
        Reference reference9 = new Reference("Alma", 34, 32);
        Scripture scripture9 = new Scripture(reference9, "For behold, this life is the time for men to prepare to meet God; yea, behold the day of this life is the day for men to perform their labors.");
        Reference reference10 = new Reference("3 Nephi", 11, 8);
        Scripture scripture10 = new Scripture(reference10, "And it came to pass, as they understood they cast their eyes up again towards heaven; and behold, they saw a Man descending out of heaven; and he was clothed in a white robe; and he came down and stood in the midst of them; and the eyes of the whole multitude were turned upon him, and they durst not open their mouths, even one to another, and wist not what it meant, for they thought it was an angel that had appeared unto them.");
 
        theScripture.AddScripture(scripture1);
        theScripture.AddScripture(scripture2);
        theScripture.AddScripture(scripture3);
        theScripture.AddScripture(scripture4);        
        theScripture.AddScripture(scripture5);
        theScripture.AddScripture(scripture6);
        theScripture.AddScripture(scripture7);
        theScripture.AddScripture(scripture8);
        theScripture.AddScripture(scripture9);
        theScripture.AddScripture(scripture10);

                
        Scripture scripture = theScripture.GetRandomIndex(); 

        return scripture;
    }

}