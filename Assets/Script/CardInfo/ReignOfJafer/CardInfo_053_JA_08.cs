using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_053_JA_08 : CardInfo
{
    public CardInfo_053_JA_08()
    {
        this.cardNo = "053_JA_08";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "クスコ";
        this.cardName2 = "ヒマになった王様";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.RachelElese;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
