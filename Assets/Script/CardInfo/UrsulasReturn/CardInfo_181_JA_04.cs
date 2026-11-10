using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_181_JA_04 : CardInfo
{
    public CardInfo_181_JA_04()
    {
        this.cardNo = "181_JA_04";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ル・フウ";
        this.cardName2 = "抜け目ない子分";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KendallHale;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
