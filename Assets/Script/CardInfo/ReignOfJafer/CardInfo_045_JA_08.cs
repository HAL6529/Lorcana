using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_045_JA_08 : CardInfo
{
    public CardInfo_045_JA_08()
    {
        this.cardNo = "045_JA_08";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "宮殿の衛兵";
        this.cardName2 = "幻影兵";
        this.power = 1;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.EvaWidermann;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Ally, EnumController.Class.Illusion };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Vanish };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
