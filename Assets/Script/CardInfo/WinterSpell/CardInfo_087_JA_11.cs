using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_087_JA_11 : CardInfo
{
    public CardInfo_087_JA_11()
    {
        this.cardNo = "087_JA_11";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "トッド";
        this.cardName2 = "ひとりぼっち";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MarianaMoreno;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.TheFoxAndTheHound;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
