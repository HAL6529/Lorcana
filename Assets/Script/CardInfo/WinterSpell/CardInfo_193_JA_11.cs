using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_193_JA_11 : CardInfo
{
    public CardInfo_193_JA_11()
    {
        this.cardNo = "193_JA_11";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "ジョン・スミス";
        this.cardName2 = "不屈の守護者";
        this.power = 3;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.GraceTran;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.Pocahontas;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
