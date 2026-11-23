using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_043_JA_11 : CardInfo
{
    public CardInfo_043_JA_11()
    {
        this.cardNo = "043_JA_11";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ダークウィング・ダック";
        this.cardName2 = "ダークウルフ・ドッグ";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.StefanoSpagnuolo;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Super, EnumController.Class.Hero, EnumController.Class.Detective };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Rush };
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.DarkwingDuck;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
