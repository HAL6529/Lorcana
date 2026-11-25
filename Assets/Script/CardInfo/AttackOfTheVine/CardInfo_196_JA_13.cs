using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_196_JA_13 : CardInfo
{
    public CardInfo_196_JA_13()
    {
        this.cardNo = "196_JA_13";
        this.inkCost = 8;
        this.availableInk = true;
        this.cardName1 = "オムニドロイド";
        this.cardName2 = "究極学習バージョン";
        this.power = 8;
        this.toughness = 8;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.SamNielson;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Robot };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift6, EnumController.KeywordAvility.Resist2 };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TheIncredibles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
