using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_241_JA_09 : CardInfo
{
    public CardInfo_241_JA_09()
    {
        this.cardNo = "241_JA_09";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ミニーマウス";
        this.cardName2 = "スイート・ハート・プリンセス";
        this.power = 2;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AlicePisoni;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.Fabled_vol2;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
