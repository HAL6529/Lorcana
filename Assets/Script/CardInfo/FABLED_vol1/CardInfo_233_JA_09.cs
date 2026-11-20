using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_233_JA_09 : CardInfo
{
    public CardInfo_233_JA_09()
    {
        this.cardNo = "233_JA_09";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "パワーライン";
        this.cardName2 = "ワールド・グレート・ロックスター";
        this.power = 6;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MaxUlichney;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift4, EnumController.KeywordAvility.Singer9 };
        this.expansion = EnumController.Expansion.Fabled_vol1;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
