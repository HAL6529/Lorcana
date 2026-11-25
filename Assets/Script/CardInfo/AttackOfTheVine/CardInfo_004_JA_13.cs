using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_004_JA_13 : CardInfo
{
    public CardInfo_004_JA_13()
    {
        this.cardNo = "004_JA_13";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "タイラー・グエン・ベイカー";
        this.cardName2 = "４タウニー";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.DevMadanAndLeonardoGiammichele;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TurningRed;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
