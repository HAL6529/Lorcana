using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_192_JA_12 : CardInfo
{
    public CardInfo_192_JA_12()
    {
        this.cardNo = "192_JA_12";
        this.inkCost = 1;
        this.availableInk = false;
        this.cardName1 = "ジョン・スミス";
        this.cardName2 = "手練れの探検家";
        this.power = 1;
        this.toughness = 1;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JulieVu;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Pocahontas;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
