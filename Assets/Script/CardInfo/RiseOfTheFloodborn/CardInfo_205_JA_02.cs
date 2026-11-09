using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_205_JA_02 : CardInfo
{
    public CardInfo_205_JA_02()
    {
        this.cardNo = "205_JA_02";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ƒVƒ“ƒfƒŒƒ‰";
        this.cardName2 = "•‘“¥‰ï‚Ì‰ÔŒ`";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CaseyRobin;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Singer3 };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.WinnieThePooh;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
