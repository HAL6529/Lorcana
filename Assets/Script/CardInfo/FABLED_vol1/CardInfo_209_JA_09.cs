using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_209_JA_09 : CardInfo
{
    public CardInfo_209_JA_09()
    {
        this.cardNo = "209_JA_09";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "クスコ";
        this.cardName2 = "追われてるラマ";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MichaelaMartin;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.Fabled_vol1;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}
