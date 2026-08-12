using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_194_JA_01 : CardInfo
{
    public CardInfo_194_JA_01()
    {
        this.cardNo = "194_JA_01";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ティンカー・ベル";
        this.cardName2 = "小さな戦術家";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = "Grace Tran";
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally, EnumController.Class.Fairy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
