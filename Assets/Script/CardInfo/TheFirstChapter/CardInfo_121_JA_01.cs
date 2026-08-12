using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_121_JA_01 : CardInfo
{
    public CardInfo_121_JA_01()
    {
        this.cardNo = "121_JA_01";
        this.inkCost = 6;
        this.availableInk = false;
        this.cardName1 = "ƒ‰ƒvƒ“ƒcƒFƒ‹";
        this.cardName2 = "”¯‚Ì–Ñ‚ð‚¨‚ë‚µ‚Ä";
        this.power = 5;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = "Clio Wolfensberger";
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
