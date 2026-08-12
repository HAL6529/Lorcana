using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_148_JA_01 : CardInfo
{
    public CardInfo_148_JA_01()
    {
        this.cardNo = "148_JA_01";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ÉWÉÉÉXÉ~Éì";
        this.cardName2 = "Ç®îEÇ—â§èó";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = "R. La Barbera / L.Giammichele";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
