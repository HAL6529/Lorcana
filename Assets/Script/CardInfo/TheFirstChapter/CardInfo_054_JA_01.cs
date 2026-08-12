using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_054_JA_01 : CardInfo
{
    public CardInfo_054_JA_01()
    {
        this.cardNo = "054_JA_01";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ƒ‰ƒtƒBƒL";
        this.cardName2 = "“ä‚ß‚¢‚½Œ«ŽÒ";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = "Giula Riva";
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Mentor, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Rush };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
