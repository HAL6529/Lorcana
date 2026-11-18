using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_052_JA_08 : CardInfo
{
    public CardInfo_052_JA_08()
    {
        this.cardNo = "052_JA_08";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "王宮警備兵";
        this.cardName2 = "タコになった衛兵";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.RachelElese;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
