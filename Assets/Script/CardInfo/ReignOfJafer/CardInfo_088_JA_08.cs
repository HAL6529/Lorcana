using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_088_JA_08 : CardInfo
{
    public CardInfo_088_JA_08()
    {
        this.cardNo = "088_JA_08";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "チャカ";
        this.cardName2 = "生き物クラブの部員";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.FlorenciaVazquez;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
