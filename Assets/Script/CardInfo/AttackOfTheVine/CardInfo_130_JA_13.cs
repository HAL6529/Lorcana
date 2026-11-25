using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_130_JA_13 : CardInfo
{
    public CardInfo_130_JA_13()
    {
        this.cardNo = "130_JA_13";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "フック船長";
        this.cardName2 = "狡猾な海賊";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JaviSalas;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Pirate, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
