using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_236_JA_12 : CardInfo
{
    public CardInfo_236_JA_12()
    {
        this.cardNo = "236_JA_12";
        this.inkCost = 8;
        this.availableInk = true;
        this.cardName1 = "キーダ";
        this.cardName2 = "クリスタルを継ぐもの";
        this.power = 7;
        this.toughness = 7;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.KennethAnderson;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift6 };
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
