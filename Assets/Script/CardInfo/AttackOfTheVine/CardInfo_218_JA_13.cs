using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_218_JA_13 : CardInfo
{
    public CardInfo_218_JA_13()
    {
        this.cardNo = "218_JA_13";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "サン・イー";
        this.cardName2 = "赤きパンダの魂";
        this.power = 5;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.Kapik;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.RedPanda };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.TemporaryRedPandaShift2 };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TurningRed;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}
