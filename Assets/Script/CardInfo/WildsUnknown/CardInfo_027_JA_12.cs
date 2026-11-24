using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_027_JA_12 : CardInfo
{
    public CardInfo_027_JA_12()
    {
        this.cardNo = "027_JA_12";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "チップ";
        this.cardName2 = "チームプレイヤー";
        this.power = 2;
        this.toughness = 7;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.CamKendell;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Chipmunk;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
