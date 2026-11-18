using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_089_JA_08 : CardInfo
{
    public CardInfo_089_JA_08()
    {
        this.cardNo = "089_JA_08";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ティポ";
        this.cardName2 = "生き物クラブの部員";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.FlorenciaVazquez;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
