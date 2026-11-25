using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_007_JA_13 : CardInfo
{
    public CardInfo_007_JA_13()
    {
        this.cardNo = "007_JA_13";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "メイ・リー";
        this.cardName2 = "リード・ボーカリスト";
        this.power = 0;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.DennyMinonne;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.RedPanda };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Singer3 };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TurningRed;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
