using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_081_JA_13 : CardInfo
{
    public CardInfo_081_JA_13()
    {
        this.cardNo = "081_JA_13";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "トッド";
        this.cardName2 = "かしこいきつね";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.Noukah;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> {  EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TheFoxAndTheHound;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
