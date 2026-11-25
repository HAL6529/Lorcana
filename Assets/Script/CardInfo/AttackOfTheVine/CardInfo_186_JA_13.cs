using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_186_JA_13 : CardInfo
{
    public CardInfo_186_JA_13()
    {
        this.cardNo = "186_JA_13";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "メガボルト";
        this.cardName2 = "脅威！ビリビリ怪人！";
        this.power = 1;
        this.toughness = 4;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.EmilyAbeydeera;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Super, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.DarkwingDuck;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
