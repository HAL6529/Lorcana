using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_229_JA_09 : CardInfo
{
    public CardInfo_229_JA_09()
    {
        this.cardNo = "229_JA_09";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ジーニー";
        this.cardName2 = "ランプの精";
        this.power = 2;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.GraceTran;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.Fabled_vol1;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
