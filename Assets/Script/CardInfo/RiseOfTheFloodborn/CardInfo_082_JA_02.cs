using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_082_JA_02 : CardInfo
{
    public CardInfo_082_JA_02()
    {
        this.cardNo = "082_JA_02";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "フリン・ライダー";
        this.cardName2 = "オレの最大のファンであるオレ";
        this.power = 2;
        this.toughness = 3;
        this.lore = 4;
        this.illustrator = EnumController.Illustrator.E_MeleranciAndL_Giammichele;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift2, EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
