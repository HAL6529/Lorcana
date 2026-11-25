using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_148_JA_13 : CardInfo
{
    public CardInfo_148_JA_13()
    {
        this.cardNo = "148_JA_13";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ベル";
        this.cardName2 = "どんな時だって読書";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.PaulineVoss;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
