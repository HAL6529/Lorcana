using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_054_JA_03 : CardInfo
{
    public CardInfo_054_JA_03()
    {
        this.cardNo = "054_JA_03";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ƒ‰ƒtƒBƒL";
        this.cardName2 = "“ä‚ß‚¢‚½“¬Žm";
        this.power = 0;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.OttoParedes;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Mentor, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Challenger3 };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
