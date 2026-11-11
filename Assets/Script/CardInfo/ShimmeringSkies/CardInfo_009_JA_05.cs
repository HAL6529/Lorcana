using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_009_JA_05 : CardInfo
{
    public CardInfo_009_JA_05()
    {
        this.cardNo = "009_JA_05";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ヴァネロペ・フォン・シュウィーツ";
        this.cardName2 = "キャンディ・メカニック";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.HedvigHaggman_Sund;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Princess, EnumController.Class.Racer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.WreckItRalph;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
