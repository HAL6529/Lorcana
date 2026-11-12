using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_071_JA_07 : CardInfo
{
    public CardInfo_071_JA_07()
    {
        this.cardNo = "071_JA_07";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "クスコ";
        this.cardName2 = "パニクったラマ";
        this.power = 2;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.FlorenciaVazquez;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst, EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
