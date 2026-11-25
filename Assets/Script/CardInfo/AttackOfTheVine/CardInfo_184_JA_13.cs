using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_184_JA_13 : CardInfo
{
    public CardInfo_184_JA_13()
    {
        this.cardNo = "184_JA_13";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ハムスターヴィール博士";
        this.cardName2 = "邪悪なる監視者";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.ChemeneDeHeus;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Alien, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Alert };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.MonstersInc;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
