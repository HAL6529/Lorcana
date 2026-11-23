using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_085_JA_11 : CardInfo
{
    public CardInfo_085_JA_11()
    {
        this.cardNo = "085_JA_11";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "コッパー";
        this.cardName2 = "猟犬の子";
        this.power = 2;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MarianaMoreno;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Puppy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.TheFoxAndTheHound;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
