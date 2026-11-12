using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_111_JA_07 : CardInfo
{
    public CardInfo_111_JA_07()
    {
        this.cardNo = "111_JA_07";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ハートの王";
        this.cardName2 = "小うるさい君主";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.IsaiahMesq;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
