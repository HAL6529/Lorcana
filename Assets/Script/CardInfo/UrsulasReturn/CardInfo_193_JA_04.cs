using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_193_JA_04 : CardInfo
{
    public CardInfo_193_JA_04()
    {
        this.cardNo = "193_JA_04";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "ÉâÅ[ÉÑ";
        this.cardName2 = "ïsâ¬é~ÇÃêÌóÕ";
        this.power = 3;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.GraceTran;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Challenger2, EnumController.KeywordAvility.Resist2 };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.RayaAndTheLastDragon;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
