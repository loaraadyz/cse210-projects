using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{

    private Reference _reference;
    private List<Word> _words = new List<Word>();


    
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string [] splitText = text.Split(" ");
        foreach (string word in splitText)
        {
            _words.Add(new Word(word));
        }

        
    }
    public void HideRandomWords( int numberToHide)
    {
        int i=0;
        int wordsToHide = Math.Min(numberToHide, _words.Count(word => !word.IsHidden()));
        do{
            Random random = new Random();
            int index=random.Next(_words.Count);
            if(!_words[index].IsHidden())
            {
               _words[index].Hide(); 
               i++;
               break;
            }   
        } while (i < wordsToHide);
    }

    public string GetDisplayText()
    {
        List<string> displayText = new List<string>();

        foreach (Word word in _words)
        {
            displayText.Add(word.IsHidden() ? new string('_', word.GetDisplayText().Length) : word.GetDisplayText());
        }

        return $"{_reference.GetDisplayText()}\n{string.Join(" ", displayText)}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }


}

