using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_115_JA_11 : CardInfo
{
    public CardInfo_115_JA_11()
    {
        this.cardNo = "115_JA_11";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ネガダック";
        this.cardName2 = "ダックルゲンガー";
        this.power = 4;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JulianDelRey;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Super, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.DarkwingDuck;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
