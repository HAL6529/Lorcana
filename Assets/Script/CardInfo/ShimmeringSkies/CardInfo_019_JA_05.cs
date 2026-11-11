using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_019_JA_05 : CardInfo
{
    public CardInfo_019_JA_05()
    {
        this.cardNo = "019_JA_05";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ヴァネロペ・フォン・シュウィーツ";
        this.cardName2 = "シュガー・ラッシュの王女様";
        this.power = 2;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.SamantaErdini;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Princess, EnumController.Class.Racer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift2 };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.WreckItRalph;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
