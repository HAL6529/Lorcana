using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_143_JA_06 : CardInfo
{
    public CardInfo_143_JA_06()
    {
        this.cardNo = "143_JA_06";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ƒˆƒEƒJƒC";
        this.cardName2 = "“ä‚ß‚¢‚½”­–¾‰Æ";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JuanDiegoLeon;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
