using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_053_JA_13 : CardInfo
{
    public CardInfo_053_JA_13()
    {
        this.cardNo = "053_JA_13";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ウーおばあちゃん";
        this.cardName2 = "賢明な祖母";
        this.power = 1;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.PaulineVoss;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Mentor, EnumController.Class.RedPanda };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Challenger2 };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TurningRed;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
