using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_045_JA_07 : CardInfo
{
    public CardInfo_045_JA_07()
    {
        this.cardNo = "045_JA_07";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "クスコ";
        this.cardName2 = "クジラになった王様";
        this.power = 1;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.LucaPinelli;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
