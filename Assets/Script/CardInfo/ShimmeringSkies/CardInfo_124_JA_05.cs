using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_124_JA_05 : CardInfo
{
    public CardInfo_124_JA_05()
    {
        this.cardNo = "124_JA_05";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ヴァネロペ・フォン・シュウィーツ";
        this.cardName2 = "隠されたレーサー";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.HyunaLee;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess, EnumController.Class.Racer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Rush };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.WreckItRalph;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
